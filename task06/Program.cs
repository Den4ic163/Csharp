// Напишите программу, которая выводит случайное трехзнвчное число и удаляет вторую цифру этого числа

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int number1=number/100;
int number3=number%10;
Console.WriteLine(number1*10+number3);