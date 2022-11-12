

Console.Write("Введите количество строк массива 1: ");
int rows1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива 1: ");
int columns1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество строк массива 2: ");
int rows2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива 2: ");
int columns2 = int.Parse(Console.ReadLine() ?? "");

int[,] array1 = new int[rows1, columns1];
int[,] array2 = new int[rows2, columns2];
FillArray(array1);
FillArray(array2);
int[,] array3 = new int[rows1, rows1];
for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < rows1; j++)
    {
        for (int k = 0; k < rows1; k++)
        {
            array3[i, j] = array3[i, j] + (array1[i, k] * array2[k, j]);
        }
    }
}
Console.WriteLine("Первая матрица:");
PrintArray(array1);
Console.WriteLine("Вторая матрица:");
PrintArray(array2);
Console.WriteLine("Результат перемножения матриц:");
PrintArray(array3);


void FillArray(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
