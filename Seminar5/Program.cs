internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the minimum value of the array ");
        int minValue = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the maximum value of the array ");
        int maxValue = Convert.ToInt32(Console.ReadLine());

        int[] array = RandomArrey(size, minValue, maxValue);
        ShowArray(array);
        /* int[] newArray = ReplacesElements(array);
        ShowArray(newArray);
        
        System.Console.WriteLine("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(FindNumber(array, number));
        */
        System.Console.WriteLine("Enter the minimum value of the segment");
        int minSegment = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the maximum value of the segment");
        int maxSegment = Convert.ToInt32(Console.ReadLine());
        int count = FindNumberOfElements(array, minSegment, maxSegment);
        System.Console.WriteLine($"The number of array elements in the segment {minSegment} - {maxSegment} = {count}");
        
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

    /*Написать программу, заменяющую
     положительные элементы массива
     на отрицательные и наоборот.*/
     static int[] ReplacesElements(int[] array) 
     {
        for (int i = 0; i < array.Length; i++)
        {
           array[i] = 0 - array[i];
        }

        return array;
     }

     /*Написать программу, определяющую, 
     присутствует ли заданное число в массиве.*/

     static bool FindNumber(int[] array, int number)
     {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number) 
            {
                return true;
            }
        }
        return false;
     }

     /*Задать массив из n элементов, 
     определить кол-во элементов, 
     принадлежащих отрезку [a,b].*/
     
     static int FindNumberOfElements(int[] array, int minValue, int maxValue)
     {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= minValue & array[i] <= maxValue)
            {
                count ++;
            }
        }
        return count;
     }
}