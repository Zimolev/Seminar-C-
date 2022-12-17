internal class Program
{
    private static void Main(string[] args)
    {
        //Example2();
        //Example4();
        //Example6();
        //Example8();
    }
/* Задача 2: Напишите программу, 
которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
*/
    private static void Example2() 
    {
        while (true)
        {
            Console.WriteLine("Введите два целых числа не равных друг другу");
            Console.Write("Первое число: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber != secondNumber) 
            {
                if (firstNumber > secondNumber) 
                {
                    Console.WriteLine("Максимальное число: " + firstNumber);
                    Console.WriteLine("Минимальное число: " + secondNumber);
                    break;
                }
                else
                {
                    Console.WriteLine("Максимальное число: " + secondNumber);
                    Console.WriteLine("Минимальное число: " + firstNumber);
                    break;
                }
            }
            else
                Console.WriteLine("Числа равны между собой, попробуте снова");
        }
    }

/* Задача 4: Напишите программу, 
    которая принимает на вход три числа 
    и выдаёт максимальное из этих чисел
*/
    private static void Example4()
    {
        Console.WriteLine("Введите три целых числа не равных друг другу");
        Console.Write("Первое число: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Второе число: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Третье число: ");
        int thirdNumber = Convert.ToInt32(Console.ReadLine());
        int max = firstNumber; 
        if (secondNumber > max) max = secondNumber;
        if (thirdNumber > max) max = thirdNumber;
        Console.Write("Максимум: " + max);
    }

    /* Задача 6: Напишите программу, 
    которая на вход принимает число и выдаёт, 
    является ли число чётным (делится ли оно на два без остатка).
*/
    private static void Example6()
    {
        Console.Write("Введите целое число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        Console.WriteLine(number + " -четное");
        else
        Console.WriteLine(number + " -нечетное");
    }

    /* Задача 8: Напишите программу, 
    которая на вход принимает число (N), 
    а на выходе показывает все чётные числа от 1 до N.
*/
    private static void Example8()
    {
        Console.Write("Введите целое число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int i = 2; 
        while (i <= number)
        {
            Console.WriteLine(i);
            i = i + 2;
        }
    }
}