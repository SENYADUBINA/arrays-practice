using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int[] numbers = new int[10];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
        }

        Console.WriteLine("Массив: " + string.Join(", ", numbers));

        int sum = 0;
        long product = 1;
        int even = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            product *= numbers[i];

            if (numbers[i] % 2 == 0)
            {
                even++;
            }
        }

        double average = (double)sum / numbers.Length;

        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > average)
            {
                count++;
            }
        }

        Console.WriteLine("Сумма: " + sum);
        Console.WriteLine("Произведение: " + product);
        Console.WriteLine("Чётных чисел: " + even);
        Console.WriteLine("Больше среднего (" + average.ToString("F1") + "): " + count);
    }
}