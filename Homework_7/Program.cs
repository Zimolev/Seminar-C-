internal class Program
{
    private static void Main(string[] args)
    {
       //double[,] array = CreateRandom2DArrayDouble();
       //Show2DArrayDouble(array);
       //System.Console.WriteLine("Введите номер строки: ");
       //int rows = Convert.ToInt32(Console.ReadLine());
       //System.Console.WriteLine("Введите номер столбца: ");
       //int columns = Convert.ToInt32(Console.ReadLine());

       //Task50(array, rows, columns);

        int[,] matrix = CreateRandom2DArray();
        Show2DArray(matrix);
        double[] array = SumArrayColumns(matrix);
        ShowArray(array);

        

    }

    /*Задача 47. Задайте двумерный массив размером m×n, 
    заполненный случайными вещественными числами.*/

     static double[,] CreateRandom2DArrayDouble()
    {
        System.Console.WriteLine("Enter the rows of the array: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the columns of the array: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        
        double[,] array = new double[rows, columns];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = new Random().NextDouble() * 100 - 50;
            }
        }
        return array;
    }

    static void Show2DArrayDouble(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.Write(array[i,j] + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }

    /*Задача 50. Напишите программу, 
    которая на вход принимает позиции элемента в двумерном массиве, 
    и возвращает значение этого элемента или же указание, 
    что такого элемента нет.*/

    static void Task50(double [,] array, int i, int j)
    {
        if (i <= array.GetLength(0) || j <= array.GetLength(1))
            System.Console.WriteLine($"Значение элемента по адресу i = {i}, j = {j} равно {array[i,j]}");
        else
            System.Console.WriteLine($"Элемента по адресу i = {i}, j = {j} нет");
    }

    /*Задача 52. Задайте двумерный массив из целых чисел. 
    Найдите среднее арифметическое элементов в каждом столбце.*/

    static int[,] CreateRandom2DArray()
    {
        System.Console.WriteLine("Enter the rows of the array: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the columns of the array: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the minimum value of the array ");
        int minValue = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the maximum value of the array ");
        int maxValue = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, columns];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = new Random().Next(minValue, maxValue + 1);
            }
        }
        return array;
    }

    static void Show2DArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.Write(array[i,j] + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }

    static double[] SumArrayColumns(int[,] array)
    {
        double[] sumColumns = new double[array.GetLength(1)];
        double sum;
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum = sum + array[i,j];
            }

            sumColumns[j] = sum / array.GetLength(0);
        }
        return sumColumns;
    }

    static void ShowArray(double[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " \t");
        }
        Console.WriteLine();
    }


}