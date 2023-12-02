using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.den
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Advent of Code 2020 - first day");

            //int y = 1;
            //int z = 1;
            //int x = 0;

            //List<int> cisla = new List<int>();

            //for (int i = 0; i < 1;)
            //{
            //    cisla[z] = Console.Read();
            //    if (cisla[z] == 0)
            //    {
            //        i++;
            //    }
            //    z++;
            //}

            List<int> cisla = new List<int>();

            int input;
            cisla.Add(0);
            int[] sumContent = new int[] { 0, 0 };
            int output;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    cisla.Add(input);
                }
                else
                {
                    break;
                }
            }
            foreach (int item in cisla)
            {
                int a = item;
                foreach (int item2 in cisla)
                {
                    int sum = item + item2;
                    if (sum == 2020)
                    {
                        sumContent[0] = item;
                        sumContent[1] = item2;
                        break;
                    }
                }
            }
            output = sumContent[0] * sumContent[1];
            Console.WriteLine(output);
            Console.ReadKey();

            //do
            //{
            //    cisla[x] = int.TryParse(Console.ReadLine());
            //} while (!int.TryParse(Console.ReadLine(), out cisla[x]));

            Console.ReadLine();
        }
    }
}
