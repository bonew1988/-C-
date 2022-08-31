//Поиск элемента массива по запросу пользователя

Console.Clear();
Console.WriteLine("Поиск элемента массива по запросу пользователя"); Console.WriteLine("---------------------------------------------- ");
int[] array = {456345,456,45645,6456,456,546,12,345,678,64,6,78,645,645,68,746,15,645};
Console.WriteLine();
Console.WriteLine("Введите значение из массива: ");
Console.WriteLine();
int n = array.Length;
int index = 0;
while (index < n)
{
    if (index <= n)
    {
        Console.Write(array[index]); Console.Write(", ");
    }
    index++;
}
Console.WriteLine();
int find = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int index1 = 0;
while (index1 < n)
{
    if (array[index1] == find)
    {
        Console.WriteLine(index1);
        break;
    }
    index1++;
}

