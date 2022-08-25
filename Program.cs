//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int [10];

List<int> arr = new List<int>();

for(int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(100,999);

}

for(int j = 0; j < array.Length; j++)
{
   if(array[j] % 2 == 0)
   {
      arr.Add(array[j]);

   }
}  
   Console.Write("[");

   for(int r = 0; r < array.Length; r++)
   {
      Console.Write(array[r] + " ");
   }

   Console.Write("]");
   
Console.WriteLine(", количество четных чисел в массиве - " + arr.Count);


//  Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


int[] array = new int [5];

for(int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(1,20);

}

int sum = 0;
for(int i = 0; i < array.Length; i++)
{
   if(i % 2 != 0)
   {
      sum += array[i];
   }
}

Console.Write("[");
for(int i = 0; i < array.Length; i++)
{
    Console.Write("" + array[i] + " ");
}
Console.Write("]");
Console.WriteLine(" Сумма нечетных элементов массива - " + sum);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

 double[] array = {12.5,30,-3,10,15};
 
 double max = array[0];
 
 double min = array[0];

 double result = 0;

 
for(int i = 0; i < array.Length; i++)
{
    if(array[i] >= max)
    {
      max = array[i];
    }
}
for(int i = 0; i < array.Length; i++)
{
    if( array[i] <= min)
    {
      min = array[i];
    }
}

result = max - min;

Console.WriteLine("Разница max и min составляет: " + result);


