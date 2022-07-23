// 1. Создать исходный массив строк
// 2. Проверить длину каждой строки массива
// 3. Сформировать новый массив строк из строк длиною меньшей или равной 3 символам
// 4. Вывести результат

 string[] array = {"hello", "2", "world", ":-)"};
// string[] array = {"1234", "1567", "-2", "computer science"};
// string[] array = {"Russia", "Denmark", "Kazan"};

int CountOfNeedSymbols(string[] arr) // подсчет подходящих строк
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}

void MainTask(string[] arrayIsh, string[] arrayNew) // подсчет подходящих строк
{
    int length = arrayIsh.Length;
    int indexArray = 0;
    int indexNewArray = 0;

    while (indexArray < length)
    {
        if (arrayIsh[indexArray].Length <= 3)
        {
            arrayNew[indexNewArray] = arrayIsh[indexArray];
            indexNewArray = indexNewArray + 1;
        }
        indexArray = indexArray + 1;
    }
}

string Print(string[] arr)
{
    int length = arr.Length;
    string output = String.Empty;
    for (int i = 0; i < length; i++)
    {
        output += ($"{arr[i]} ");
    }
    return output;
}

int count = CountOfNeedSymbols(array); // подсчет подходящих строк для последующего создания нового массива определенной длины
Console.WriteLine($"Исходный массив: {Print(array)}");

if (count != 0)
{
    string[] newArray = new string[count];
    MainTask(array, newArray);

    string output = Print(newArray);
    Console.WriteLine($"Новый массив: {output}");
    File.WriteAllText("output.txt",output);
}
else
{
    Console.WriteLine("В данном массиве нет подходящих строк!");
}

