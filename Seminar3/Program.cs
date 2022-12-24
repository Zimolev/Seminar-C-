internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите две координаты x & y");
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());
        int x2 = Convert.ToInt32(Console.ReadLine());
        int y2 = Convert.ToInt32(Console.ReadLine());
        //Task0(quadrant);
        //Task1(x, y);
        //Task2(x);
        Console.WriteLine(Task3(x1, y1, x2, y2));
     }


static void Task0(int quadrant)
/*Напишите программу, которая по заданному номеру четверти,
 показывает диапазон возможных координат точек в этой четверти (x и y).
*/
    {
        if (quadrant == 1) Console.WriteLine(" x > 0, y > 0");
        else if (quadrant == 2) Console.WriteLine(" x < 0, y > 0");
        else if (quadrant == 3) Console.WriteLine(" x < 0, y < 0");
        else if (quadrant == 4) Console.WriteLine(" x > 0, y < 0");
        else Console.WriteLine("Не правильный ввод");
    }

    static void Task1(int x, int y)
    /*Напишите программу, которая принимает на вход координаты 
    точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
    в которой находится эта точка.
    */
    {
        if (x > 0 && y > 0) Console.WriteLine(" Первая четверть");
        else if (x < 0 && y > 0) Console.WriteLine(" Вторая четверть");
        else if (x < 0 && y < 0) Console.WriteLine(" Третья четверть");
        else if (x > 0 && y < 0) Console.WriteLine(" Четвертая четверть");
        else Console.WriteLine("Не правильно введене координаты");
    }
static void Task2(int number)
    /* Напишите программу, которая принимает на вход число (N) 
    и выдаёт таблицу квадратов чисел от 1 до N.
    */
    {
        int count = 1;
       while (count <= number)
       {
         Console.WriteLine(Math.Pow(count, 2));
         count++;
       }
        
    }

static double Task3(int x1, int y1, int x2, int y2)
    /*Напишите программу, 
    которая принимает на вход координаты двух точек
    и находит расстояние между ними в 2D пространстве.
    */
    {
        int x = x1 - x2;
        int y = y1 - y2;
        return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
    }

  

   

}
