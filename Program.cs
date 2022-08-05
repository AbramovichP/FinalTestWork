// Метод создает массив из введеных пользователем эллементов из консоли
// elements - кол-во элементов массива
string[] CreateArray(int elements)
{
    string[] array = new string[elements];

    for(int i = 0; i < elements; i++)
    {
        Console.WriteLine($"Введите {i} эллемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] myarray = CreateArray(n);
Console.WriteLine("[" + string.Join(" ", myarray) + "]");

