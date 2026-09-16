using System;

class Program
{
    static void Main()
    {
        int n = 0;

        while (n <= 0)
        {
            Console.Write("Введите количество элементов: ");

            try
            {
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine("Ошибка: число должно быть больше 0.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите целое число!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Число слишком большое!");
            }
        }

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write("Элемент [" + i + "]: ");

                try
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: Число слишком большое!");
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Исходный массив:  " + string.Join(", ", numbers));

        Console.Write("Обратный порядок: ");

        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(numbers[i]);

            if (i != 0)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine();

        Array.Sort(numbers);

        Console.WriteLine("Отсортированный:  " + string.Join(", ", numbers));

        int min = numbers[0];
        int max = numbers[0];

        for (int i = 1; i < n; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }

            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine("Максимум: " + max);
        Console.WriteLine("Минимум: " + min);
    }
}