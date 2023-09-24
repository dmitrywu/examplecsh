int[] array = { 2, 5, 12, 4, 36, 7, 91, 8, 4 };

int n = array.Length;
Console.WriteLine(n);

int find = 4;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}