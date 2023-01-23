internal class Program
{
    private static void Main(string[] args)
    {
        int[,] array = CreateArray();
        Show2DArray(array);
        //ArrayReqest(array);
        //Show2DArray(array);
        System.Console.WriteLine(SumArrayDioganal(array));
    }

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

    /*Задайте двумерный массив размера m на n, 
    каждый элемент в массиве находится по формуле: 
    Aij = i+j. Выведите полученный массив на экран.*/
    
    static int[,] CreateArray()
    {
        System.Console.WriteLine("Enter the rows of the array: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the columns of the array: ");
        int columns = Convert.ToInt32(Console.ReadLine());
       
        int[,] array = new int[rows, columns];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = i + j;
            }
        }
        return array;
    }

    /*Задайте двумерный массив. 
    Найдите элементы, у которых оба индекса чётные, 
    и замените эти элементы на их квадраты.*/

    static void ArrayReqest(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i = i + 2)
        {
            for (int j = 0; j < array.GetLength(1); j = j + 2)
            {
                array[i,j] = Convert.ToInt32(Math.Pow(array[i,j], 2));
            }
        }
    }

    /*Задайте двумерный массив. 
    Найдите сумму элементов, находящихся на главной диагонали 
    (с индексами (0,0); (1;1) и т.д.*/

    static int SumArrayDioganal(int[,] array)
    {
        int sum = 0;
        int size;
        if (array.GetLength(0) > array.GetLength(1))
            size = array.GetLength(1);
        else
            size = array.GetLength(0);
        for (int i = 0; i < size; i++) // for (int i = 0; i < GetLength(1) && i < GetLength(0); i++)
        {
            sum = sum + array[i, i];
        }
        return sum;
    }
}