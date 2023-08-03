// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void Fill(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите строку {i}");
        string j = Console.ReadLine()!;
        array[i] = j;
    }
}

void PrintArr(string[] array)
{
    Console.WriteLine(); 
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

string [] SortArr(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            size++;
        }
    }
    
    string [] array2 = new string[size];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[j] = array[i];
            j++;
        }
    }
    return array2;
}

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine()!);

string[] arr = new string[size];
Fill(arr);
PrintArr(arr);
string[] arr2 = SortArr(arr);
PrintArr(arr2);
