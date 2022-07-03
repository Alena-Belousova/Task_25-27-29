// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//в натуральную степень B.
Console.WriteLine("задача 25");
Console.Write("введите значение А ");//3
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение B ");//5
int b = Convert.ToInt32(Console.ReadLine());
int resolt= 1;
int count = 0;
while(count<b)
{
resolt= resolt*a;
count++;
}
Console.WriteLine("A^B= "+resolt);