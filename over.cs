using System;
class Checked
{
    static void Main()
    {
        try
        {
            checked{
                sbyte a = 64;
                sbyte b = 65;
                sbyte c = (sbyte)(a+b);
                Console.Write(c);
            }
        }
        catch(OverflowException ex) {
            Console.Write(ex.Message);

        }
    }
}