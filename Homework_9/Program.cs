internal class Program
{
    private static void Main(string[] args)
    {
        //ShowNumber(13);
        //System.Console.WriteLine(ShowSumNumber(10, 1));
        System.Console.WriteLine(FunctionsAkkerman(3, 7));
    }

    /*Задача 64: Задайте значение N. Напишите программу, 
    которая выведет все натуральные числа в промежутке
     от N до 1. Выполнить с помощью рекурсии.*/
    static void ShowNumber(int number)
    {
        System.Console.Write(number + " ");
        if (number > 1) ShowNumber(number - 1);
    }

    /*Задача 66: Задайте значения M и N. 
    Напишите программу, которая найдёт сумму 
    натуральных элементов в промежутке от M до N.*/
    static int ShowSumNumber(int n, int m)
    {

        if (n > m) return ShowSumNumber(n - 1, m) + n;
        if (m > n) return ShowSumNumber(n, m - 1) + m;
        else return m;
    }

    /*Задача 68: Напишите программу вычисления 
    функции Аккермана с помощью рекурсии. 
    Даны два неотрицательных числа m и n*/

    static int FunctionsAkkerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else
            if (n == 0 && m > 0)
        {
            return FunctionsAkkerman(m - 1, 1);
        }
        else
        {
            return (FunctionsAkkerman(m - 1, FunctionsAkkerman(m, n - 1)));
        }
    }
}