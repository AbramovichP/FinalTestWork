// Метод создает массив из введеных пользователем эллементов с клавиатуры
// elements - кол-во элементов массива(задается пользователем с клавиатуры)
string[] CreateArrayWords(int elements)
{
    string[] words = new string[elements];

    for(int i = 0; i < elements; i++)
    {
        Console.WriteLine($"Введите {i+1} эллемент массива: ");
        string? n = Console.ReadLine();
        if(n != null)
            words[i] = n;
    }
    return words;
}

string[] FormingArrayStrings(string[] words)
{
    string[] wordArray = new string[words.Length];
    for(int i = 0; i < words.Length; i++)
    {
        if(words[i].Length <= 3)wordArray[i] = words[i];
    }
    return wordArray;
}
Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] mywords = CreateArrayWords(n);
Console.WriteLine("[" + string.Join(" ", mywords) + "]");

string[] collectedWord = FormingArrayStrings(mywords);
Console.WriteLine("[" + string.Join(" ",collectedWord) + "]");
