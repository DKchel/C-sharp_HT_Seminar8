// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.WriteLine("Введите первую размерность массива");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите вторую размерность массива");
int columns = int.Parse(Console.ReadLine());

int[,] array = new int[rows, columns];

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void GetArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

GetArray ();
PrintArray(array);

void ChangeArray()
{
    int temp = 0;
    int indexLastRows = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[0, i];
        array[0, i] = array[indexLastRows, i];
        array[indexLastRows, i] = temp;
    }
}

ChangeArray();
Console.WriteLine();
PrintArray(array);

Console.WriteLine("Введите размерность");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите размерность");
int columns = int.Parse(Console.ReadLine());

int[,] matrix = new int[rows,columns];

void GetArray()
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i,j] = new Random().Next(0,10);
}
}
}