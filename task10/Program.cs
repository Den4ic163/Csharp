//Напишите программу которая на вход принимает два числа и проверяет является ли одно квадратом другого

Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
//if (Math.Pow(number1, 2)==number2 || Math.Pow(number2, 2)==number1)
if (number1==number2*number2 || number2==number1*number1)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}