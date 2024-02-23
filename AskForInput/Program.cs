using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user input and parse to int:
            Console.WriteLine("Please write a integer number:");
            int userin_int = int.Parse(Console.ReadLine());   

            //Parse to float:
            Console.WriteLine("Please write a real number:");
            float userin_float = float.Parse((Console.ReadLine()));         
            
            //Add the values together:
            float userint_sum = userin_int + userin_float;

        }
    }
}
