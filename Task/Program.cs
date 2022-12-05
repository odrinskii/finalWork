// Задача. 
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами. 


string[] CreateStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"'{array[i],2}', ");
        else Console.Write($"'{array[i],2}'");
    }
    Console.WriteLine("]");
}


string[] NewStringArray(string[] array)
{
    int goodElementsCount = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) goodElementsCount++;
    }

    string[] newArray = new string[goodElementsCount];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}


Console.Write("Введите размер массива: ");
int len = Convert.ToInt32(Console.ReadLine());
if (len > 0)
{
    string[] stringArray = new string[len];
    stringArray = CreateStringArray(stringArray);
    Console.Write("Сгенерированный массив: ");
    PrintArray(stringArray);
    string[] editedArray = NewStringArray(stringArray);
    Console.Write("Искомый массив: ");
    PrintArray(editedArray);
}
else Console.WriteLine("Ошибка! Чтобы задать размер массива введите целое натуральное число");
