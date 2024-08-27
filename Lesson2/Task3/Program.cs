int n = 10;
int[] arr = new int[n];
int i = 0;

Console.WriteLine("Вывод всех элементов массива: ");
while (i < arr.Length)
{
    arr[i] = new Random().Next(1, 100);
    // Console.Write(arr[i]);
    // Console.Write(" ");
    Console.Write($"{arr[i]} ");
    i++;
}

i = 0;
Console.WriteLine("Вывод только чётных элементов массива: ");
while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
    // if (arr[i] mod 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i++;
}