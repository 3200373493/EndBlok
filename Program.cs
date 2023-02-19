// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

Console.Clear();
Console.Write("ВВЕДИТЕ КОЛИЧЕСТВО ЭЛЕМЕНТОВ МАССИВА = ");
int M = Convert.ToInt32(Console.ReadLine());
string[] array1 = EnterMas(M);
string[] array2 = new string[array1.Length];
ArrayResult(array1, array2);
Console.WriteLine("ИСХОДНЫЙ МАССИВ:");
PrintArray(array1);
Console.WriteLine("МАССИВ С ЭЛЕМЕНТАМИ РАЗМЕРОМ <=3: ");
PrintArray(array2);

void ArrayResult(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[j] = array1[i];
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
string[] EnterMas(int M)
{
    string[] array1 = new string[M];
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine("ВВЕДИТЕ {0}-й ЭЛЕМЕНТ МАССИВА", i + 1);
        array1[i] = Convert.ToString(Console.ReadLine());
    }
    return array1;
}