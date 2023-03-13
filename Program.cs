// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна
// 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] array = new string[4] { "hello", "2", "world", ":-)" };
string[] array2 = new string[array.Length];
void FirstArray(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
}

void SecondArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine();
}
FirstArray(array, array2);
SecondArray(array2);