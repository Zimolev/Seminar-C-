internal class Program
{
    
    private static void Main(string[] args)
    {
        //int[,] matrix = CreateRandom2DArray();
        //Show2DArray(matrix);
        //ChangeArrayRowsRevers(matrix);
        //Show2DArray(matrix);
        //int minSumRowArray = MinSumRowArray(matrix);
        //System.Console.WriteLine("номер строки c наименьшей суммой элементов " + (minSumRowArray + 1)); 
        //int[,] matrix2 = CreateRandom2DArray();
        //Show2DArray(matrix2);
        //int[,] matrixTomatrix = SumTowMatrix(matrix, matrix2);
        //Show2DArray(matrixTomatrix);
        //int[,,] matrix = CreateRandom3DArray();
        //Show3DArray(matrix);
        int[,] matrix = Create2DArrayZero();
        SpiralArray(0, 0, 1, matrix);
        Show2DArray(matrix);
    }

    
    /*Задача 54: Задайте двумерный массив. 
    Напишите программу, которая упорядочит 
    по убыванию элементы каждой строки двумерного массива.*/
    static void ChangeArrayRowsRevers (int [,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int r = 0; r < array.GetLength(1) -1; r++)
                {
                    if (array[i, r] < array[i, r + 1])
                    {
                        int temp = array[i , r + 1];
                        array[i, r + 1] = array[i, r];
                        array[i ,r] = temp;
                    }
                }
            }
        }
    } 

    /*Задача 56: Задайте прямоугольный двумерный массив. 
    Напишите программу, которая будет находить строку
    с наименьшей суммой элементов.*/

    static int MinSumRowArray(int[,] array)
    {
        int[] sumRow = new int[array.GetLength(0)];
        int min;
        int row;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum = sum + array[i, j];
            }
            sumRow[i] = sum;
        }

        min = sumRow[0];
        row = 0;

        for (int i = 1; i < sumRow.Length; i++)
        {
            if (min > sumRow[i])
            {
                min = sumRow[i];
                row = i;
            }         
        }
        return row; 
    }

    /*Задача 58: Задайте две матрицы. 
    Напишите программу, которая будет 
    находить произведение двух матриц.
    */

    static int[,] SumTowMatrix(int[,] array1, int[,] array2)
    {
        int[,] matrix = new int[array1.GetLength(0), array2.GetLength(1)];
        //int n = array1.GetLength(1);
        if (array1.GetLength(1) == array2.GetLength(0))
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                    for (int n = 0; n < array1.GetLength(1); n++)
                    {
                        matrix[i, j] = matrix[i, j] + (array1[i, n] * array2[n, j]);   
                    }
                }                
            }
        }
        return matrix;
    }

    /*Задача 60. Сформируйте трёхмерный массив из 
    неповторяющихся двузначных чисел. 
    Напишите программу, которая будет построчно 
    выводить массив, добавляя индексы каждого элемента.*/
    static int[,,] CreateRandom3DArray()
    {
        System.Console.WriteLine("Enter the width of the array: ");
        int size1 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the length of the array: ");
        int size2 = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the height of the array: ");
        int size3 = Convert.ToInt32(Console.ReadLine());
        
        System.Console.WriteLine();

        int[,,] array = new int[size1, size2, size3];
        int[] number = new int[90];
        for (int i = 0, count = 10; i < 90; i++, count++)
        {
            number[i] = count;
        }
        if ((size1 * size2 * size3) <= 90)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        while (array[i, j, k] == 0)
                        {
                            int countNumber = new Random().Next(0, 90);
                            array[i, j, k] = number[countNumber];
                            number[countNumber] = 0;
                        }
                    }
                }
            }
        }
        
        return array;
    }

    static void Show3DArray(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                 System.Console.Write($"{array[i,j,k]} ({i}, {j}, {k}); ");
                 System.Console.WriteLine();   
                }
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }

    /*Задача 62. Напишите программу, 
    которая заполнит спирально массив i на j.*/

    static int[,] Create2DArrayZero()
    {
        System.Console.WriteLine("Enter the rows of the array: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the columns of the array: ");
        int columns = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the minimum value of the array ");
        
        int[,] array = new int[rows, columns];
        
        return array;        
    }

    static void SpiralArray(int i, int j, int count, int[,] pic)
    { 
        if (i < pic.GetLength(0) && i >=0 && j>=0 && j < pic.GetLength(1))
        {
            if(pic[i, j] == 0)
            {
                pic[i,j] = count;
                count++;
                SpiralArray(i, j + 1, count, pic);
                SpiralArray(i - 1, j, count, pic);
                SpiralArray(i + 1, j, count, pic);
                SpiralArray(i, j - 1, count, pic);
                
            }
            
        }
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
}
