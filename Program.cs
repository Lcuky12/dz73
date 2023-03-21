using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp77
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[30];
            int maxNumbers = arrayNumbers[0];

            Random random = new Random();

            int minNumber = 1;
            int maxNumber = 100;
            int maxNumberRepetitions = 0;
            int currentNumberRepetitions = 1;
            int number = 1;

            Console.WriteLine(" Числа ");

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = random.Next(minNumber, maxNumber + 1);

                Console.Write(arrayNumbers[i] + " ");
            }

            Console.WriteLine();

            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] == arrayNumbers[i - number])
                {
                    currentNumberRepetitions++;

                    if (currentNumberRepetitions > maxNumberRepetitions)
                    {
                        maxNumberRepetitions = currentNumberRepetitions;
                        maxNumbers = arrayNumbers[i];
                    }
                }

                else
                {
                    Console.WriteLine(" Максимальное число повторений не выявлено ");
                    currentNumberRepetitions = number;
                }
            }

            Console.WriteLine(" Число " + maxNumbers + " повторяется " + maxNumberRepetitions + " раза подряд ");
        }
    }
}
