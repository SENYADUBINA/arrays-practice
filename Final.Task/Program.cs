using System;

class Program
{
    static void Main(string[] args)
    {
        // Вариант 1. Температура за неделю

        double[] temperatures = { 22.5, 23.1, 19.8, 21.3, 24.0, 25.2, 20.7 };

        double average = 0;

        for (int i = 0; i < temperatures.Length; i++)
        {
            average += temperatures[i];
        }

        average = average / temperatures.Length;

        double max = temperatures[0];
        double min = temperatures[0];

        for (int i = 1; i < temperatures.Length; i++)
        {
            if (temperatures[i] > max)
            {
                max = temperatures[i];
            }

            if (temperatures[i] < min)
            {
                min = temperatures[i];
            }
        }

        int count = 0;

        for (int i = 0; i < temperatures.Length; i++)
        {
            if (temperatures[i] > 20)
            {
                count++;
            }
        }

        Console.WriteLine("Температура за неделю: " + string.Join(", ", temperatures));
        Console.WriteLine("Средняя температура: " + average.ToString("F1") + " °C");
        Console.WriteLine("Максимальная температура: " + max + " °C");
        Console.WriteLine("Минимальная температура: " + min + " °C");
        Console.WriteLine("Дней выше 20 °C: " + count);
    }
}