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
        
        //int[] array = Fibonachi(size, minValue, maxValue);
        int[] array = RandomArrey(size, minValue, maxValue);
        ShowArray(array);
        //ReserveArray(array);
        //ShowArray(array);
        //System.Console.WriteLine(Treugulnik(size, minValue, maxValue));
        int[] copyArray = CopyAray(array);
        array[0] = -1000;
        ShowArray(array);
        ShowArray(copyArray);

    }

    static void ReserveArray(int[] array)
    {
        for (int i = 0, j = array.Length - 1;  i <j; i++, j--)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
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

/*Напишите программу, которая принимает на вход три числа
 и проверяет, может ли существовать треугольник
 с сторонами такой длины.*/
    static bool Treugulnik(int a, int  b, int c)
    {
        return (a + b > c && a + c > b && c + b > a);
    }

/* Не используя рекурсию, 
выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: a и b.*/
    static int[] Fibonachi(int n, int a, int b)
    {
        int[] array = new int[n];
        array[0] = a;
        array[1] = b;
        for (int i = 2; i < array.Length; i++)
        {
            array[i] = array[i - 1] + array[i - 2];
        }
        return array;
    }

/* Напишите программу, которая будет создавать
 копию заданного массива с помощью 
 поэлементного копирования.*/

 static int[] CopyAray(int[] array)
 {
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
 }
}
