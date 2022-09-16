// Написать программу, которая из имеющегося массива строк формирует новый массив 
// из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно 
// ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
Console.Write("Ввведите 1 элемент: ");
string N1 = Console.ReadLine();

Console.Write("Ввведите 2 элемент: ");
string N2 = Console.ReadLine();

Console.Write("Ввведите 3 элемент: ");
string N3 = Console.ReadLine();

Console.Write("Ввведите 4 элемент: ");
string N4 = Console.ReadLine();

Console.Write("Ввведите 5 элемент: ");
string N5 = Console.ReadLine();

string[] arr1 = new string[5] {N1, N2, N3, N4, N5};
string[] arr2 = new string[arr1.Length];
void AddElementsNewArray(string[] arr1, string[] arr2)
{
    int j = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[j] = arr1[i];
        j++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
AddElementsNewArray(arr1, arr2);
PrintArray(arr1);
PrintArray(arr2);
