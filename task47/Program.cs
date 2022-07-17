// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.



double [,] GetSumArray(int m, int n)
{
    double [,] variable = new double [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            variable[i,j] = new Random().NextDouble();
        }
    }
    return variable;
}   

void PrintArray( double [,] array1)
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

int m = 4;
int n = 4;
double[,] array = GetSumArray(m, n);
PrintArray(array);