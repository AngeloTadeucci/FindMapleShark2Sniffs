using FindMapleShark2Sniffs.MapleShark2_Files;

namespace FindMapleShark2Sniffs;

public static class FilterHelpers
{
    public static bool FilterOpCode(IEnumerable<MaplePacket> packets, decimal opCodeValue, bool outBound)
    {
        return packets.Any(packet => packet.Opcode == opCodeValue && packet.Outbound == outBound);
    }

    public static bool FilterMode(IEnumerable<MaplePacket> packets, decimal opCodeValue, decimal modeValue, bool outBound, decimal length = 0)
    {
        foreach (MaplePacket packet in packets.Where(x => x.Opcode == opCodeValue && x.Outbound == outBound))
        {
            byte mode;
            try
            {
                mode = packet.ReadByte();
            }
            catch (IndexOutOfRangeException)
            {
                continue;
            }

            if (mode == modeValue && packet.Length >= length)
            {
                return true;
            }
        }

        return false;
    }

    public static bool FilterLength(IEnumerable<MaplePacket> packets, decimal opCodeValue, decimal length)
    {
        return packets.Where(x => x.Opcode == opCodeValue).Any(packet => packet.Length >= length);
    }

    public static bool SearchBytes(IEnumerable<MaplePacket> packets, byte[] bytes)
    {
        return packets.Any(x => x.Search(bytes) > -1);
    }
}
