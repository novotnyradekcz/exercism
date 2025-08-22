using System;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] buffer = new byte[9];
        byte[] number;

        if (reading < int.MinValue)
        {
            buffer[0] = 248;
            number = BitConverter.GetBytes(reading);
        }
        else if (reading < short.MinValue)
        {
            buffer[0] = 252;
            number = BitConverter.GetBytes((int)reading);
        }
        else if (reading < 0)
        {
            buffer[0] = 254;
            number = BitConverter.GetBytes((short)reading);
        }
        else if (reading <= ushort.MaxValue)
        {
            buffer[0] = 2;
            number = BitConverter.GetBytes((ushort)reading);
        }
        else if (reading <= int.MaxValue)
        {
            buffer[0] = 252;
            number = BitConverter.GetBytes((int)reading);
        }
        else if (reading <= uint.MaxValue)
        {
            buffer[0] = 4;
            number = BitConverter.GetBytes((uint)reading);
        }
        else
        {
            buffer[0] = 248;
            number = BitConverter.GetBytes(reading);
        }
        number.CopyTo(buffer, 1);
        return buffer;
    }

    public static long FromBuffer(byte[] buffer)
    {
        if (buffer[0] == 2)
            return BitConverter.ToUInt16(buffer, 1);
        else if (buffer[0] == 4)
            return BitConverter.ToUInt32(buffer, 1);
        else if (buffer[0] == 248)
            return BitConverter.ToInt64(buffer, 1);
        else if (buffer[0] == 252)
            return BitConverter.ToInt32(buffer, 1);
        else if (buffer[0] == 254)
            return BitConverter.ToInt16(buffer, 1);
        else
            return 0l;
    }
}
