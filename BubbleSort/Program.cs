namespace BubbleSort
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = { 3, 44, 38, 5, 47, 15, 36, 26, 27, 2, 46, 4, 19, 50, 48 };

            bool swapped = true;

            do
            {
                swapped = false;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    int leftElement = numbers[i];
                    int rightElement = numbers[i + 1];

                    if (leftElement > rightElement)
                    {
                        numbers[i] = rightElement;
                        numbers[i + 1] = leftElement;

                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
