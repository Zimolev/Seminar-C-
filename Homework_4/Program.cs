internal partial class Program
{
    private static void Main(string[] args)
    {
       System.Console.WriteLine("First number");
       int firstNumber = Convert.ToInt32(Console.ReadLine());
       //System.Console.WriteLine("Second number");
       //int secondNumber = Convert.ToInt32(Console.ReadLine());
       //System.Console.WriteLine(Task25(firstNumber, secondNumber));
       System.Console.WriteLine(Task27(firstNumber));
    }

    /*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
    и возводит число A в натуральную степень B.
    */
    static int Task25(int firstNumber, int secondNumber)
    {
        int result = 1;
        for (int i = 1; i <= secondNumber; i++)
        {
            result = result  * firstNumber;
        }
        return result;
    }

    /*Задача 27: Напишите программу, которая принимает на вход число
     и выдаёт сумму цифр в числе.
     */

    static int Task27(int number)
    {
        int sum = 0;
        int bitNumber = number; 
        while (number != 0)
        {            
            sum = sum + number%10;
            number = number/10;
        }
        return sum;
    }
    

    /*Задача 29: Напишите программу, которая задаёт массив из m элементов
     и выводит их на экран.
     */
    
    //static void Task29()
    
}