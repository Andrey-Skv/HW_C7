// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
// элементов в каждом столбце.

int [,] SumArray(int a, int b)
{
    int [,] result = new int[a,b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            result[i,j] = new Random().Next(0,10);
        }
    }
    return result;
}

void PrintArray(int [,] myArr)
{
    for (int i = 0; i < myArr.GetLength(0); i++)
    {
        for (int j = 0; j < myArr.GetLength(1); j++)
        {
            Console.Write($"{myArr[i,j]} ");
        }
        Console.WriteLine();
    }
}

double [] mean(int [,] arr2)

{   double [] anyMean = new double[arr2.GetLength(1)];
    for (int j = 0; j < arr2.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr2.GetLength(0); i++)
        {
            sum = sum + arr2[i,j];
        }   
        anyMean[j] = sum/arr2.GetLength(0);
    }   
      return anyMean;
}

void PrintArr(double [] myArr)
{
    for (int i = 0; i < myArr.GetLength(0); i++)
    {
    
        Console.Write($"{myArr[i]} ");
    }
    Console.WriteLine();
}   

int a = 3;
int b = 4;
int [,] array = SumArray(a,b);
PrintArray(array);
Console.WriteLine();
PrintArr(mean(array));