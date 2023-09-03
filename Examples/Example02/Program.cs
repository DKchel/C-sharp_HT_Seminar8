// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.WriteLine("Введите первую размерность массива");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] matrix = new int[rows, rows];

int[,] matrix2 = new int[rows, rows];

void PrintArray(int[,] array)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            matrix2[j, i] = array[i, j];
        }
    }
}

GetArray(matrix);
PrintArray(matrix);
ChangeArray(matrix);
Console.WriteLine();
PrintArray(matrix2);

