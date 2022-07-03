// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("задача 29");
int[] array=new int [8];
int n=8;
Console.Write("массив из восьми чисел: ");
for(int index= 0; index<n; index++)
{
  array[index]  = new Random().Next(1,10);
 
  Console.Write(array[index] + " ");
  }
