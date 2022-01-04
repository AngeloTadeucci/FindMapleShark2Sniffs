﻿// From Ochi's MapleShark2 https://github.com/kOchirasu/MapleShark2

namespace FindMapleShark2Sniffs.Tools;

public class MsbMetadata
{
    public string LocalEndpoint;
    public ushort LocalPort;
    public string RemoteEndpoint;
    public ushort RemotePort;
    public byte Locale;
    public uint Build;
}

public static class FileLoader
{
    private const ushort LEGACY_VERSION = 0x2027;
    private const ushort VERSION = 0x2030;

    public static void WriteMsbFile(string fileName, MsbMetadata metadata, IEnumerable<MaplePacket> packets)
    {
        using (var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
        {
            var writer = new BinaryWriter(stream);
            writer.Write(VERSION);
            writer.Write(metadata.LocalEndpoint);
            writer.Write(metadata.LocalPort);
            writer.Write(metadata.RemoteEndpoint);
            writer.Write(metadata.RemotePort);
            writer.Write(metadata.Locale);
            writer.Write(metadata.Build);

            foreach (MaplePacket packet in packets)
            {
                ArraySegment<byte> segment = packet.GetSegment(packet.Offset, packet.Length);
                if (segment.Array == null)
                {
                    continue;
                }

                writer.Write((ulong)packet.Timestamp.Ticks);
                writer.Write(segment.Count);
                writer.Write(packet.Opcode);
                writer.Write((byte)(packet.Outbound ? 1 : 0));
                writer.Write(segment.Array, segment.Offset, segment.Count);
            }

            stream.Flush();
        }
    }

    public static void WriteLegacyMsbFile(string fileName, MsbMetadata metadata, IEnumerable<MaplePacket> packets)
    {
        using (var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
        {
            var writer = new BinaryWriter(stream);
            writer.Write(LEGACY_VERSION);
            writer.Write(metadata.LocalEndpoint);
            writer.Write(metadata.LocalPort);
            writer.Write(metadata.RemoteEndpoint);
            writer.Write(metadata.RemotePort);
            writer.Write(metadata.Locale);
            writer.Write(metadata.Build);

            foreach (MaplePacket packet in packets)
            {
                ArraySegment<byte> segment = packet.GetSegment(packet.Offset, packet.Length);
                if (segment.Array == null)
                {
                    continue;
                }

                writer.Write((ulong)packet.Timestamp.Ticks);
                writer.Write(segment.Count);
                writer.Write(packet.Opcode);
                writer.Write((byte)(packet.Outbound ? 1 : 0));
                writer.Write(segment.Array, segment.Offset, segment.Count);
                writer.Write(0); // PreDecodeIV
                writer.Write(0); // PostDecodeIV
            }

            stream.Flush();
        }
    }

    public static (MsbMetadata, IEnumerable<MaplePacket>) ReadMsbFile(string fileName)
    {
        var metadata = new MsbMetadata();
        List<MaplePacket> packets = new List<MaplePacket>();

        using (var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
        {
            var reader = new BinaryReader(stream);
            ushort version = reader.ReadUInt16();
            if (version < 0x2000)
            {
                metadata.Build = version;
                metadata.LocalPort = reader.ReadUInt16();
                metadata.Locale = MapleLocale.UNKNOWN;
            }
            else
            {
                byte v1 = (byte)((version >> 12) & 0xF),
                    v2 = (byte)((version >> 8) & 0xF),
                    v3 = (byte)((version >> 4) & 0xF),
                    v4 = (byte)((version >> 0) & 0xF);

                if (version == 0x2012)
                {
                    metadata.Locale = (byte)reader.ReadUInt16();
                    metadata.Build = reader.ReadUInt16();
                    metadata.LocalPort = reader.ReadUInt16();
                }
                else if (version == 0x2014)
                {
                    metadata.LocalEndpoint = reader.ReadString();
                    metadata.LocalPort = reader.ReadUInt16();
                    metadata.RemoteEndpoint = reader.ReadString();
                    metadata.RemotePort = reader.ReadUInt16();

                    metadata.Locale = (byte)reader.ReadUInt16();
                    metadata.Build = reader.ReadUInt16();
                }
                else if (version == 0x2015 || version >= 0x2020)
                {
                    metadata.LocalEndpoint = reader.ReadString();
                    metadata.LocalPort = reader.ReadUInt16();
                    metadata.RemoteEndpoint = reader.ReadString();
                    metadata.RemotePort = reader.ReadUInt16();

                    metadata.Locale = reader.ReadByte();
                    metadata.Build = reader.ReadUInt32();
                }
                else
                {
                    string message = $"Invalid msb file, version: {v1}.{v2}.{v3}.{v4}";
                    MessageBox.Show(message, "MapleShark2", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return (metadata, new List<MaplePacket>());
                }
            }


            while (stream.Position < stream.Length)
            {
                long timestamp = reader.ReadInt64();
                int size = version < 0x2027 ? reader.ReadUInt16() : reader.ReadInt32();
                ushort opcode = reader.ReadUInt16();
                bool outbound;

                if (version >= 0x2020)
                {
                    outbound = reader.ReadBoolean();
                }
                else
                {
                    outbound = (size & 0x8000) != 0;
                    size = (ushort)(size & 0x7FFF);
                }

                byte[] buffer = reader.ReadBytes(size);
                if (version >= 0x2025 && version < 0x2030)
                {
                    reader.ReadUInt32(); // preDecodeIV
                    reader.ReadUInt32(); // postDecodeIV
                }

                var packet = new MaplePacket(new DateTime(timestamp), outbound, metadata.Build, opcode, new ArraySegment<byte>(buffer));
                packets.Add(packet);
            }

            return (metadata, packets);
        }
    }

    public static void ExportTxtFile(string fileName, MsbMetadata metadata, IList<MaplePacket> packets)
    {
        using (StreamWriter writer = File.AppendText(fileName))
        {
            long dataSize = 0;
            foreach (MaplePacket packet in packets)
            {
                dataSize += 2 + packet.Length;
            }

            writer.WriteLine($"=== MapleStory2 Version: {metadata.Build}; Region: {metadata.Locale} ===");
            writer.WriteLine($"Endpoint From: {metadata.LocalEndpoint}:{metadata.LocalPort}");
            writer.WriteLine($"Endpoint To: {metadata.RemoteEndpoint}:{metadata.RemotePort}");
            writer.WriteLine($"- Packets: {packets.Count}");
            writer.WriteLine($"- Data: {dataSize:N0} bytes");
            writer.WriteLine("================================================");

            foreach (MaplePacket packet in packets)
            {
                writer.WriteLine(packet);
            }
        }
    }
}
