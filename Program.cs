using System;

namespace App31
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            char number = Console.ReadLine()[0];

            bool found = false;

            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] == number) found = true;

            Console.WriteLine(found);
        }
    }
}
