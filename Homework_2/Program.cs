internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите трехзначное число, если введете не трехзначное ответ будет -1 ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Наша вторая цифра числа {number} это {Task10(number)}");
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
}