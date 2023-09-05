// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matrix = new int[4, 4];

int num = 1;

for (int i = 0; i < 1; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrix[i, j] = num;
        num++;
    }
}

for (int j = 3; j < 4; j++)
{
    for (int i = 0; i < 4; i++)
    {
        matrix[i, j] = num;
        num++;
    }
}

for (int i = 3; i < 4; i++)
{
    for (int j = 2; j > -1; j--)
    {
        matrix[i, j] = num;
        num++;
    }
}

for (int j = 0; j < 1; j++)
{
    for (int i = 2; i > 0; i--)
    {
        matrix[i, j] = num;
        num++;
    }
}

for (int i = 1; i < 2; i++)
{
    for (int j = 1; j < 3; j++)
    {
        matrix[i, j] = num;
        num++;
    }
}

for (int i = 2; i < 3; i++)
{
    for (int j = 2; j > 0; j--)
    {
        matrix[i, j] = num;
        num++;
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)

            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
            Console.WriteLine();
    }
}

PrintArray(matrix);