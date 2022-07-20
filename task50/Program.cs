// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int [,] Array( int a, int b)
{   int [,] result = new int[a,b];

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            result[i,j] = new Random().Next(0,10);
        }
    }
    return result;
}

void PrintArray(int [,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FindNumber(int[,] Array, int num)
{
   int rows = -1;
   int column = -1;
   for(int i = 0; i < Array.GetLength(0); i++)
   {
      for (int j = 0; j < Array.GetLength(1); j++)
      {
         if (num == Array[i,j]) 
         {
            rows = i;
            column = j;
            Console.WriteLine($"Введённое число {num} находится в строке {i} столбце {j}");
         }
      }
   }
   if (rows < 0 && column < 0)
   Console.WriteLine($"Введённое число {num} отсутствует в заданном массиве");
}

Console.WriteLine("Введите количество строк");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число");
int num = Convert.ToInt32(Console.ReadLine());
int [,] myArray = Array(a,b);
PrintArray(myArray);
Console.WriteLine();
FindNumber(myArray,num);