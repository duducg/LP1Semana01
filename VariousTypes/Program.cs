using System;

namespace VariousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
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


        }
    }
}
