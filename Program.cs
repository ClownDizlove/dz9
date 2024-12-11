using System;

public class LinearSearchProgram
{
    
    public static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i; 
        }
        return -1; 
    }

    
    public static int[] GenerateRandomArray(int size, int minValue, int maxValue)
    {
        Random random = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(minValue, maxValue + 1);
        }
        return arr;
    }

    
    public static void TestLinearSearch()
    {
        Console.Write("Введите размер массива: ");
        if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
        {
            Console.WriteLine("Некорректный размер массива. Попробуйте снова.");
            return;
        }

        Console.Write("Введите минимальное значение элементов массива: ");
        if (!int.TryParse(Console.ReadLine(), out int minValue))
        {
            Console.WriteLine("Некорректное значение. Попробуйте снова.");
            return;
        }

        Console.Write("Введите максимальное значение элементов массива: ");
        if (!int.TryParse(Console.ReadLine(), out int maxValue) || maxValue < minValue)
        {
            Console.WriteLine("Некорректное значение. Попробуйте снова.");
            return;
        }

        int[] array = GenerateRandomArray(size, minValue, maxValue);

        Console.Write("Введите число для поиска: ");
        if (!int.TryParse(Console.ReadLine(), out int target))
        {
            Console.WriteLine("Некорректное число. Попробуйте снова.");
            return;
        }

        
        int index = LinearSearch(array, target);

        
        if (index != -1)
        {
            Console.WriteLine($"Число {target} найдено на индексе {index}.");
        }
        else
        {
            Console.WriteLine($"Число {target} не найдено в массиве.");
        }
    }

    
    public static void Main()
    {
        TestLinearSearch();
    }
}
