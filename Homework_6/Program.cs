internal class Program
{
    private static void Main(string[] args)
    {
        //Task43();
        System.Console.WriteLine("Введите какое количество чисел вы хотите ввести: ");
        int m = Convert.ToInt32(Console.ReadLine());
        int count = Task41(m);
        System.Console.WriteLine($"Вы ввели {count} положительных числа");
    }

    /*Задача 43: Напишите программу, которая найдёт точку 
    пересечения двух прямых, 
    заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
    значения b1, k1, b2 и k2 задаются пользователем.
y = k1 * x + b1, y = k2 * x + b2
k1 * x + b1 = k2 * x + b2
(k1 - k2) * x = b2 - b1
x = (b2 - b1) / (k1 - k2)
y = k1 * x + b1
*/
    static void Task43()
    {
        System.Console.WriteLine("Введите значение b1: ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Введите значение k1: ");
        double k1 = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Введите значение b2: ");
        double b2 = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("Введите значение k2: ");
        double k2 = Convert.ToDouble(Console.ReadLine());
        if (k1 == k2 && b1 == b2) System.Console.WriteLine("Прямые совпадают");
        if (k1 ==k2) System.Console.WriteLine("Прямые параллельны");
        double x = (b2-b1)/(k1-k2);
        double y = (k1*(b2-b1))/(k1-k2)+b1;
        System.Console.WriteLine($"Точка пересечения прямых x = {x}, y = {y}");
    }

    /*Задача 41: Пользователь вводит с клавиатуры M чисел.
     Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

     static int Task41(int m)
     {
        int count = 0;
        for (int i = 1; i <= m; i++)
        {
            System.Console.WriteLine($"Введите {i}-ое число");
            double number = Convert.ToDouble(Console.ReadLine());
            if (number > 0) count++;
        }

        return count;
     }
}