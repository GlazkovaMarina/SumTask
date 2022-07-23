// 1. Создать исходный массив строк
// 2. Проверить длину каждой строки массива
// 3. Сформировать новый массив строк из строк длиною меньшей или равной 3 символам
// 4. Вывести результат

string[] array = {"hello", "2", "world", ":-)"};
int length = array.Length;
int indexArray = 0;
int count = 0;
string[] newArray = new string[count];
int indexNewArray = 0;

int CountOfNeedSymbols(string[] arr)
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

count = CountOfNeedSymbols(array);
Console.WriteLine(count);