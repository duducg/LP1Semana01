using System;
using System.Text;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Exercício 4

            //String type variables
            //Also test escape characters:
            string m1 = "Hello, World"; 
            string m2 = "It\'s da single quotation";
            string m3 = "\"Double quotations\"";
            string m4 = "\\ backslash \\";
            string m6 = "\0"; //null
            string m7 = "..........\b....";
            string m8 = "\n newline\n another one \n another one";
            string m9 = "carriage_return\r";
            string m10 = "\ttab, \tanother tag";

            string uni01 = "Communism is a bad idea in practice and in theory";
            string comiSlander = uni01 + " \u262D";
            string anchor = "\u2693";
            string anchorSt = $"This is an anchor : {anchor}";
            
            Console.WriteLine(); //new line just for readability 
            
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);         
            Console.WriteLine(m6);//prints an empty line
            Console.WriteLine(m7);
            Console.WriteLine(m8);
            Console.WriteLine(m9);
            Console.WriteLine(m10);
            Console.WriteLine(comiSlander);
            Console.WriteLine(anchorSt);

            Console.WriteLine();

            //Exercício 5:

            //Concatenation 
            string a = "Conca";
            string b = "tenation";
            string c = a + b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine();

            //Interpolation
            string name = "Jonhson";
            string age = "45";
            string final = $"{name} is {age} years old today!";
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(final);
            





        }
    }
}
