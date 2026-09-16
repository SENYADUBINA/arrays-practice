using System;

class Program
{
    public static int[] GetUnique(int[] source)
    {
        int[] result = new int[source.Length];
        int count = 0;

        for (int i = 0; i < source.Length; i++)
        {
            bool found = false;

            for (int j = 0; j < count; j++)
            {
                if (source[i] == result[j])
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                result[count] = source[i];
                count++;
            }
        }

        int[] unique = new int[count];

        for (int i = 0; i < count; i++)
        {
            unique[i] = result[i];
        }

        return unique;
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 2, 3, 4, 4, 4, 5 };

        int[] unique = GetUnique(numbers);

        Console.WriteLine("Исходный: " + string.Join(", ", numbers));
        Console.WriteLine("Уникальные: " + string.Join(", ", unique));
    }
}