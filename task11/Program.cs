// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
/*
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10)
{
    Console.WriteLine(number);
}
else
{
    while (number > 0) 
    {
        int result = number % 10;
        number= number/10;
        if (number > 0)
        {
            Console.Write(result + ",");
        }
        else
        {
            Console.WriteLine(result);
        }
    }
}








Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
{ Console.WriteLine(N); }
else
{
    while (N > 0)
    {
        int currentDigit = N % 10;
        N=N/10;
        if(N > 0)
        {
            Console.Write(currentDigit + ",");
        }
else
        {
            Console.WriteLine(currentDigit);
        }
    }
}
*/



/*Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
*/
Console.Write("Введите координаты точки x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("номер координатной четверти плоскости 1");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("номер координатной четверти плоскости 2");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("номер координатной четверти плоскости 3");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("номер координатной четверти плоскости 4");
}
else
{
    Console.WriteLine("значения x и y не должны равняться 0");
}