

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
void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) // строчки
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++) // столбцы
        {
            Console.Write(inputMatrix[i, m] + "\t"); //"\t" - Tab
        }
        Console.WriteLine();
    }
}


Console.Write("Введите строку: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int column = Convert.ToInt32(Console.ReadLine());

if (row < resultMatrix.GetLength(0) && column < resultMatrix.GetLength(1)) Console.WriteLine(resultMatrix[row, column]);
else Console.WriteLine("такого числа в массиве нет");