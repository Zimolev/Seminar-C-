internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of the array");
        int size = Convert.ToInt32(Console.ReadLine());

        //System.Console.WriteLine("Enter the minimum value of the array ");
        //int minValue = Convert.ToInt32(Console.ReadLine());
        //System.Console.WriteLine("Enter the maximum value of the array ");
        //int maxValue = Convert.ToInt32(Console.ReadLine());

        //int[] array = RandomArrey(size, minValue, maxValue);
        //int[] array = RandomArrey3x(size);
        
        //ShowArray(array);
        //System.Console.WriteLine($"There are {Task34(array)} even elements in the array");
        //System.Console.WriteLine("Сумма элементов, стоящих на нечётных позициях = " + Task36(array) );
        double[] array = RandomArreyDouble(size);
        ShowArrayDouble(array);
        System.Console.WriteLine(Task38(array));

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
    static int[] RandomArrey3x(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(100, 1001);
        }
        return array;
    } 

    static double[] RandomArreyDouble(int size)
    {
        double[] array = new double[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().NextDouble() * 100 - 50;
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

    static void ShowArrayDouble(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    /*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    Напишите программу, которая покажет количество чётных чисел в массиве.*/

    static int Task34(int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) result++;
        }
        return result;
    }

    /*Задача 36: Задайте одномерный массив, 
    заполненный случайными числами. 
    Найдите сумму элементов, стоящих на нечётных позициях.*/

    static int Task36(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i+=2)
            sum = sum + array[i];
        return sum;
    }

    /*Задача 38: Задайте массив вещественных чисел. 
    Найдите разницу между максимальным и минимальным элементов массива.*/
    static double Task38(double[] array)
    {
        double max = array[0];
        double min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max) 
                max = array[i];
            else
            if(array[i] < min) 
                min = array[i];
        }
        return max - min;
    }

}