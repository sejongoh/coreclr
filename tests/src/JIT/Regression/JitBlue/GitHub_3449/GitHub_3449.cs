using System;

public class Program
{
    public static int Main(string[] args)
    {
        ulong u64 = 0x84595161401484A0UL;
        double f64 = (double)u64;        
        long h64 = BitConverter.DoubleToInt64Bits(f64);            
        if (h64 != 0x43e08b2a2c280290L) {
            Console.WriteLine(String.Format("Expected: 0x43e08b2a2c280290UL\n Actual: {0:x}", h64));
            return -1;
        }
        return 100;
    }
}
