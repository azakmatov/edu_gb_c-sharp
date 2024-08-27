// string str = Console.ReadLine();
// Console.WriteLine(str);

int[,] CreateMatrix(int rowCount, int columnCount)
{
    int[,] matrix = new int[rowCount, columnCount];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 4);

ShowMatrix(matrix);

foreach (int e in matrix)
{
    if (isInteresting(e))
    {
        Console.WriteLine(e);
    }
}

bool isInteresting(int value)
{
    int sumDigits = GetSumOfDigits(value);
    if (sumDigits % 2 == 0)
    {
        return true;
    }
    return false;
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while (value >= 1)
    {
        sum += value % 10;
        value /= 10;
    }
    return sum;
}