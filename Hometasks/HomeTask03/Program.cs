// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите число строк первой матрицы");
int rows1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов первой матрицы");
int columns1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] array = new int[rows1, columns1];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
    }
}

Console.WriteLine();
Console.WriteLine("Введите число строк второй матрицы");
int rows2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов второй матрицы");
int columns2 = Convert.ToInt32(Console.ReadLine());

if (columns1 == rows2)
{
    int[,] array1 = new int[rows2, columns2];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = new Random().Next(0, 10);
        }
    }

    int[,] resArray = new int[rows2, columns2];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                resArray[i, j] += array[i, k] * array1[k, j];
            }
        }
    }

    void PrintArray(int[,] col)
    {
        int count = col.Length;
        for (int i = 0; i < col.GetLength(0); i++)
        {
            for (int j = 0; j < col.GetLength(1); j++)
            {
                Console.Write(col[i, j] + " ");
            }
            Console.WriteLine();
        }

    }

    PrintArray(array);
    Console.WriteLine();
    PrintArray(array1);
    Console.WriteLine();
    Console.WriteLine("Результирующая матрица:");
    PrintArray(resArray);

}

else
{
    Console.WriteLine();
    Console.WriteLine("Такие матрицы нельзя перемножить, так как количество столбцов матрицы первой матрицы не равно количеству строк второй матрицы.");
}