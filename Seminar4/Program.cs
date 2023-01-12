internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int size = Convert.ToInt32(Console.ReadLine());
        int minValue = Convert.ToInt32(Console.ReadLine());
        int maxValue = Convert.ToInt32(Console.ReadLine());

        ShowArray(RandomArrey(size, minValue, maxValue));

        //Console.WriteLine(Task1(num));
        //Console.WriteLine(Task2(num));
    }

    /*
    Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
    */

    static int Task1(int num)
    {
        int fact = 1;
        for (int i = 2; i <= num; i++)
        {
            fact = fact*i;
        }

        return fact;
    }

    /*
    Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
    */
    static int Task2(int num)
    {
        int count = 0;
        while (num > 0)
        {
            num = num / 10;
            count++;
        }
        return count;
    }

    static int[] RandomArrey(int size, int minValue, int maxValue)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(minValue, maxValue + 1);
        }
        return array;
    }

    static void ShowArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

}