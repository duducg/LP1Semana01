using System;

namespace DecimalHexa
{
    class Program
    {
        static void Main(string[] args)
        {

            //Prompt user for 4 integer numbers:
            //1
            Console.WriteLine("Please write 4 integer numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            //Print the 4 numbers to console:
            //1 per line in: 
            //Decimal
            //Hexadecimal 
            //Uppercase
            //Aligned to the right
            //uses up 6 spaces
            //2 spaces in between

            //Format:
            Console.WriteLine($"{a,6}  {a,6:X}");
            Console.WriteLine($"{b,6}  {b,6:X}");
            Console.WriteLine($"{c,6}  {c,6:X}");
            Console.WriteLine($"{d,6}  {d,6:X}");
            
        }
    }
}
