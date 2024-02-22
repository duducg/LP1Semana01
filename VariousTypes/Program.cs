using System;
using System.Text;


namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //integer type variables
            int i = -4;
            uint ui = 4U;
            sbyte sb = -128;
            short s = -1000;
            ushort us = 1000;             
            long l = -5L;
            ulong ul = 5UL;
            byte bt = 16;

            char a = 'a';
            char a_Unicode = '\u0061';
            
            //Print values:
            Console.WriteLine(i);
            Console.WriteLine(ui);
            Console.WriteLine(sb);
            Console.WriteLine(s);
            Console.WriteLine(us);
            Console.WriteLine(l);
            Console.WriteLine(ul);
            Console.WriteLine(bt);
            Console.WriteLine(a);
            Console.WriteLine(a_Unicode);

            //different Unicode values for type char
            char hammerAndSickle = '\u262D';
            char skullAndCrossBones = '\u2620';
            char blackSpaceSuitEmoji = '\u2660';
            char withoutSnowEmoji = '\u26C4';
            char starOfDavidEmoji = '\u2721';
            char anchorEmoji = '\u2693';


            //Print Unicode values:
            Console.WriteLine(hammerAndSickle);
            Console.WriteLine(skullAndCrossBones);
            Console.WriteLine(blackSpaceSuitEmoji);
            Console.WriteLine(withoutSnowEmoji);
            Console.WriteLine(starOfDavidEmoji);
            Console.WriteLine(anchorEmoji);

            //"real" type variables

            float f = 16.4633f;
            double db = 26.4423;
            decimal dc = 2.4203m;

            Console.WriteLine(f);
            Console.WriteLine(db);
            Console.WriteLine(dc);        







        }
    }
}
