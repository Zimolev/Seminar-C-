internal class Program
{
    private static void Main(string[] args)
    {
     int[,] newArray = CreateRandom2DArray();
     Show2DArray(newArray);
     /*System.Console.WriteLine("Enter the rows1 of the array: ");
     int r1 = Convert.ToInt32(Console.ReadLine());
     System.Console.WriteLine("Enter the rows2 of the array: ");
     int r2 = Convert.ToInt32(Console.ReadLine());
     ChangeRows(newArray, r1, r2);
     ChangeRowColumns(newArray);
     Show2DArray(newArray);*/
     int[,] changeArray = NewChangeArray(newArray);
     Show2DArray(changeArray);
     

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
        System.Console.WriteLine();

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
    /*Задайте двумерный массив. 
    Напишите программу, которая поменяет 
    местами строки массива.*/
    static void ChangeRows(int[,] array, int r1, int r2)
    {
        if (r1 >= 0 && r1 < array.GetLength(0) &&
            r2 >= 0 && r2 < array.GetLength(0) &&
            r1 != r2)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                int temp = array[r1 , j];
                array[r1,j] = array[r2,j];
                array[r2,j] = temp;
            }
        }    
    }
/*Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы.*/

static void ChangeRowColumns(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
            
                    int temp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = temp;
            
            }
        }
    }
}

/*Из двумерного массива целых чисел 
удалить строку и столбец, на пересечении 
которых расположен наименьший элемент.*/

static int[,] NewChangeArray(int[,] array)
{
    int[,] changeArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int min = array[0, 0];
    int row = 0;
    int column = 0;
    int m = 0;
    int n = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j]) 
            {
                min = array[i, j];
                row = i;
                column = j;  
            }
        }
    }
    
    for (int i = 0; i < array.GetLength(0) ; i++)
    {
        if (i != row)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != column)
                {
                    changeArray[m, n] = array[i, j];
                    n++;
                }
            }
            m++;
            n = 0;
        }
    }
    return changeArray;
}


}
