// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)//строчки
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// столбцы
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
    return matrix;
}

int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);

void PrintArray(int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++) // строчки
    {
        for (int m = 0; m < resultMatrix.GetLength(1); m++) // столбцы
        {
            Console.Write(resultMatrix[i, m] + "\t"); 
        }
        Console.WriteLine();
    }
}


double[] arrayOfAverages = new double[resultMatrix.GetLength(1)];
double columnSum = 0;
for (int i = 0; i < resultMatrix.GetLength(1); i++)
{
    columnSum = 0;
    for (int j = 0; j < resultMatrix.GetLength(0); j++)
    {
        columnSum += resultMatrix[j, i];
    }
    arrayOfAverages[i] = columnSum / resultMatrix.GetLength(0);
}

Console.WriteLine("Средние: ");
for (int i = 0; i < resultMatrix.GetLength(1); i++) 
{
    Console.Write(Math.Round(arrayOfAverages[i], 2) + "\t"); 
}