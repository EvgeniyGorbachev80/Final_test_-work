//  Задача. Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символа. 
//  Первоночальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-"] -> ["2", ":-"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


Console.Clear();
Console.WriteLine();

string[] array = Array();
string[] result = SecondСheck(array, 3);
Console.WriteLine();
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");
Console.WriteLine();

int FirstСheck(string[] input, int n)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}

string[] SecondСheck(string[] input, int n)
{
    string[] output = new string[FirstСheck(input, n)];

    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}

string[] Array()
{
    Console.Write("Введите значения через запятую и пробел: ");
    return Console.ReadLine()!.Split(", ");
}