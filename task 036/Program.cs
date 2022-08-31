// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-10, 10);
        index ++;
    }
}

void PrintArray (int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

void SumNumbers (int[] arr) 
{
    int res = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        res += arr[i];
    }
    Console.WriteLine("Сумма элементов на нечётных позициях:" + res);
}
Console.WriteLine("Введите длину массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[ ] array = new int[n];
FillArray(array);
PrintArray(array);
SumNumbers(array);














































