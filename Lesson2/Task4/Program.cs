int n = new Random().Next(2, 10);
int[] arr = new int[n];
int i = 0;
int max = 0;
int max_count = 0;
string max_str = "";

Console.WriteLine("\nВывод весов всех гирь в кг:");
while (i < arr.Length)
{
    arr[i] = new Random().Next(1, 32);
    Console.Write($"{arr[i]} ");
    i++;
}

max = arr[0];

i = 1;

while (i < arr.Length)
{
    if (max < arr[i])
    {
        max = arr[i];
    }
    else if (max == arr[i])
    {
        max_count++;
    }
    i++;
}

if (max_count > 0)
{
    max_str = ", количество гирь с максимальным весом: {max_count}";
    Console.WriteLine($"Максимальный вес у этих гирь: {max},");
}
Console.WriteLine($"\n\nМаксимальный вес у этих гирь: {max}" + max_str);