// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
Console.WriteLine("задача 27");
Console.Write("введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
int result = 0;
if(numb/10==0)
{
    Console.WriteLine("число "+numb+ " однозначное" );
    Console.WriteLine ("суммировать нечего");
}
else
{
    while(numb%100>0)
    {
    int b = numb%10;
    numb=numb/10;
    result=result+b;
    }
}
Console.WriteLine("сумма цифр числа = " + result);

