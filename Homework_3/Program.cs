internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ввидите целое число ");
        int number = Convert.ToInt32(Console.ReadLine());
        Task23(number);
        //Task21(3, 5, 8, 8, 5, -8);
    }

/*Задача 21 Напишите программу, 
которая принимает на вход координаты 
двух точек и находит расстояние между 
ними в 3D пространстве.*/
    static void Task21(double x1, double y1,
                     double z1, double x2,
                     double y2, double z2)
    {
    double d = Math.Pow((Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2) ), 0.5);
    Console.WriteLine("Distance is \n" + d);
    }
    /*Задача 23 Напишите программу, 
    которая принимает на вход число (N) 
    и выдаёт таблицу кубов чисел от 1 до N.    
    */
    static void Task23(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(Math.Pow(i, 3));
        }
    }

    /*Задача 19 Напишите программу, 
    которая принимает на вход число 
    и проверяет, является ли оно палиндромом.*/
    static bool Task19(int number)
    {
        
    }
}