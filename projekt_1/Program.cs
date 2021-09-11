using System;
using System.Threading;

namespace projekt_1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Введи первое число: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Введи второе число: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("+ - *  / % ^");
            string c = Console.ReadLine();

            if (c == "+")
            {
                float colv = a + b;
                Console.WriteLine(colv);
            }

            else if (c == "-")
            {
                float colv = a - b;
                Console.WriteLine(colv);
            }

            else if (c == "*")
            {
                float colv = a * b;
                Console.WriteLine(colv);
            }

            else if (c == "/")
            {
                float colv = a / b;
                Console.WriteLine(colv);
            }

            else if (c == "%")
            {
                float colv1 = a / b;
                float q = (int)colv1;
                float colv = colv1 - q;
                Console.WriteLine(colv);
            }

            else if (c == "^")
            {

                float colv = 1;
                for (int i = 0; i < b; i++)
                colv *= a;
                Console.WriteLine(colv);

            }

            else
            {
                Console.WriteLine("не то");
            }
        }
    }
}