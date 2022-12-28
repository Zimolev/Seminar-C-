internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Для задания 10 введите трехзначное число, если введете не трехзначное ответ будет -1 ");
        Console.WriteLine("Для задания 13 введите любое число");
        Console.WriteLine("Для задания 15 введите цифру, обозначающую день недели ");
        int number = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"Наша вторая цифра числа {number} это {Task10(number)}");
        Task13(number);
        //Task15(number);
    }

    static int Task10(int number)
    /*Задача 10: Напишите программу, 
    которая принимает на вход трёхзначное число 
    и на выходе показывает вторую цифру этого числа.*/
    {
        int bitNumber = number;
        int count = 0;
        if (number < 0) number = 0 - number; 
            while (bitNumber != 0)
            {
                bitNumber = bitNumber / 10;
                count++;
            }
            if (count != 3) return -1;
            return number / 10 % 10;
    }

    static void Task13(int number)
    /*
    Задача 13: Напишите программу, 
    которая выводит третью цифру заданного числа или сообщает,
    что третьей цифры нет.*/
    {
        {
        int bitNumber = number;
        int count = 0;
        
        if (number < 0) number = 0 - number; 
            while (bitNumber != 0)
            {
                bitNumber = bitNumber / 10;
                count++;
            }
            if (count < 3) Console.WriteLine("Третьей цифры нет");
            else
            Console.WriteLine(number % Convert.ToInt32(Math.Pow(10, count - 2)) / Convert.ToInt32(Math.Pow(10, count - 3)));
    }
    }

    static void Task15(int number)
    /*
    Задача 15: Напишите программу, которая принимает на вход цифру, 
    обозначающую день недели, и проверяет, является ли этот день выходным.*/
    {
        if (number == 7 || number == 6) Console.WriteLine ("Это выходной день");
        
        else
            Console.WriteLine ("Это не выходной день");
    }
}