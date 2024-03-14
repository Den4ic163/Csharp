/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число 
кратным первому, если второе число не кратно первому то программа выводит остаток от деления
*/


Console.WriteLine("Введите два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1%number2==0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("некратно "+number1%number2);
}