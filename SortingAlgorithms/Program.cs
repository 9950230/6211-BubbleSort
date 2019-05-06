using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            int length = 20000;
            int[] numbers = new int[length];
            int[] numbersCopy = new int[length];
            int[] numbersCopy2 = new int[length];
            int[] numbersCopy3 = new int[length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, length);
            }

            Array.Copy(numbers, numbersCopy, length);
            Array.Copy(numbers, numbersCopy2, length);
            Array.Copy(numbers, numbersCopy3, length);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            StandardBubbleSort(numbersCopy);
            //DisplayNumbers(StandardBubbleSort(numbersCopy));
            sw.Stop();
            Console.WriteLine("Standard Bubble Sort: {0} milliseconds", sw.ElapsedMilliseconds);

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            ImprovedBubbleSort(numbersCopy2);
            //DisplayNumbers(ImprovedBubbleSort(numbersCopy2));
            sw2.Stop();
            Console.WriteLine("Improved Bubble Sort: {0} milliseconds", sw2.ElapsedMilliseconds);

            Stopwatch sw3 = new Stopwatch();
            sw3.Start();
            MoreImprovedBubbleSort(numbersCopy3);
            //DisplayNumbers(MoreImprovedBubbleSort(numbersCopy3));
            sw3.Stop();
            Console.WriteLine("More Improved Bubble Sort: {0} milliseconds\n", sw3.ElapsedMilliseconds);

            Stopwatch sw4 = new Stopwatch();
            sw4.Start();
            StandardBubbleSort(numbersCopy3);
            sw4.Stop();
            Console.WriteLine("Standard Bubble Sort on SORTED numbersCopy3: {0} milliseconds", sw4.ElapsedMilliseconds);

            Stopwatch sw5 = new Stopwatch();
            sw5.Start();
            ImprovedBubbleSort(numbersCopy3);
            sw5.Stop();
            Console.WriteLine("Improved Bubble Sort on SORTED numbersCopy3: {0} milliseconds", sw5.ElapsedMilliseconds);

            Stopwatch sw6 = new Stopwatch();
            sw6.Start();
            MoreImprovedBubbleSort(numbersCopy3);
            sw6.Stop();
            Console.WriteLine("More Improved Bubble Sort on SORTED numbersCopy3: {0} milliseconds", sw6.ElapsedMilliseconds);

            Console.ReadLine();
        }

        static void DisplayNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("{0} ", numbers[i]);
            }
        }

        static int[] StandardBubbleSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = 0; j < numbers.Length-1; j++)
                {
                    if(numbers[j] > numbers[j+1])
                    {
                        int temp = numbers[j+1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }

        // - i added
        static int[] ImprovedBubbleSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }

        // - i and swap flag added
        static int[] MoreImprovedBubbleSort(int[] numbers)
        {
            bool swap;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                swap = false;
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                        swap = true;
                    }
                }
                if (!swap) break;
            }
            return numbers;
        }
    }
}
