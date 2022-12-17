//Задайте двумерный массив размером m*n, наполненный случайными вещественными числами
Console.Clear();

void ShowArray(double [,] array)
{
    for (int i = 0; i<array.GetLength(0) ; i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

double [,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    double [,] array = new double [rows, columns]; 
    for (int i = 0; i<rows ; i++)
    {
        for (int j = 0; j<columns; j++)
        {
            array [i,j] = new Random().Next(leftRange, rightRange + 1) + Math.Round(new Random().NextDouble(), 1);
        }
    }
    return array;
}

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = EnterNumber("Введите значение m: ");
int n = EnterNumber("Введите значение n: ");

double [,] matrix= CreateRandomArray(m, n, 1, 10);
ShowArray(matrix);