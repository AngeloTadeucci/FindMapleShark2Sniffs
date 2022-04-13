using FindMapleShark2Sniffs.MapleShark2_Files;

namespace FindMapleShark2Sniffs;

public static class FilterHelpers
{
    public static bool FilterOpCode(IEnumerable<MaplePacket> packets, decimal opCodeValue, bool outBound)
    {
        return packets.Any(packet => packet.Opcode == opCodeValue && packet.Outbound == outBound);
    }

    public static bool FilterMode(IEnumerable<MaplePacket> packets, decimal opCodeValue, decimal modeValue)
    {
        foreach (MaplePacket packet in packets.Where(x => x.Opcode == opCodeValue))
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

            if (mode == modeValue)
            {
                return true;
            }
        }

        return false;
    }

    public static bool FilterLength(IEnumerable<MaplePacket> packets, decimal opCodeValue, decimal lenght)
    {
        return packets.Where(x => x.Opcode == opCodeValue).Any(packet => packet.Length >= lenght);
    }
}
