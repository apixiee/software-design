using System;
using System.Collections.Generic;
using System.Text;

namespace Task5._2
{
    public class Sorter
    {
        public int[] Numbers { get; private set; }

        public Sorter(int[] numbers)
        {
            Numbers = (int[]) numbers.Clone();
        }
        public void ArraySortDescending()
        {
            int n = Numbers.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (Numbers[j] < Numbers[j + 1])
                    {
                        int temp = Numbers[j];
                        Numbers[j] = Numbers[j + 1];
                        Numbers[j + 1] = temp;
                    }
                }
            }
        }
    }
}