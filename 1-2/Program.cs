using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.den_part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Advent of Code 2020 - first day part 2");

            List<int> cisla = new List<int>();

            int input;
            cisla.Add(0);
            int[] sumContent = new int[] { 0, 0, 0 };
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
                foreach (int item2 in cisla)
                {
                    foreach (int item3 in cisla)
                    {
                        int sum = item + item2 + item3;
                        if (sum == 2020)
                        {
                            sumContent[0] = item;
                            sumContent[1] = item2;
                            sumContent[2] = item3;
                            break;
                        }
                    }
                }
            }
            output = sumContent[0] * sumContent[1] * sumContent[2];
            Console.WriteLine(output);
            Console.ReadKey();

            Console.ReadLine();
        }
    }
}
