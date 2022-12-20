internal class Program
{
    private static void Main(string[] args)
    {
       //int number = new Random().Next(10, 99);
       int number = 10;
       int numberTwo = 100;
       //int newNumber = First(number);
       Console.WriteLine(Third(number, numberTwo));
       //Console.WriteLine($"Первоначальное число {number} полученное число {newNumber}");
    }

    static int CutNumber(int numder)
    {
        int sot = numder / 100;
        int ed = numder % 10;
        int result = sot * 10 + ed;
        return result;
    }

/*Напишите программу, которая выводит 
случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
*/
    static int First(int number)
    {
        int ten = number / 10;
        int ed = number % 10;
        if (ten > ed) return ten;
        else
        return ed;
    }
/*Напишите программу, которая будет принимать на вход два числа
 и выводить, является ли второе число кратным первому.
*/
    static bool Second(int numbeOne, int numberTwo)
    {
        return (numberTwo % numbeOne == 0);    
    }
/*
Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
*/
     static bool Third(int numberOne, int numberTwo)
     {
        return (numberOne * numberOne == numberTwo || numberTwo * numberTwo == numberOne);
     }
}  