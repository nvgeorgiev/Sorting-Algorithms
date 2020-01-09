namespace SelectionSort
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = { 3, 44, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentMinimum = numbers[i];

                int currentMinimumIndex = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int element = numbers[j];

                    if (element < currentMinimum)
                    {
                        currentMinimum = element;
                        currentMinimumIndex = j;
                    }
                }

                numbers[currentMinimumIndex] = numbers[i];
                numbers[i] = currentMinimum;
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
