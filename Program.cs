// Метод создает массив из введеных пользователем элементов с клавиатуры
// elements - кол-во элементов массива(задается пользователем с клавиатуры)
string[] CreateArrayWords(int elements)
{
    string[] words = new string[elements];

    for(int i = 0; i < elements; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива: ");
        string? n = Console.ReadLine();
        if(n != null)
            words[i] = n;
    }
    return words;
}
//Метод принимает на вход массив и считает кол-во искомых элементов меньше или равных 3
// words - входящий массив
int ElementCount(string[] words)
{
    int count = 0;
    for(int i = 0; i < words.Length; i++)
        if(words[i].Length <= 3) count++;
    
    return count;
}
//Метод формирует новый массив из элементов входящего массива согласно условиям задачи
// words - входящий массив
// count - длина нового массива
string[] FormingArrayStrings(string[] words, int count)
{
    string[] wordArray = new string[count];
    int j = 0;
    for(int i = 0; i < words.Length; i++)
    {
            if(words[i].Length <= 3)
            {
                wordArray[j] = words[i];
                j++;
            }
    }
    return wordArray;
}

Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] mywords = CreateArrayWords(n);
Console.WriteLine("Первоначальный массив: [" + string.Join(", ", mywords) + "]");

string[] collectedWord = FormingArrayStrings(mywords,ElementCount(mywords));
Console.Write("Сформированный массив из строк длинна которых меньше либо равна 3 символа: ");
Console.WriteLine("[" + string.Join(", ",collectedWord) + "]");

