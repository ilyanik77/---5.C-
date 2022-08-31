//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.

void FillArray (double[] collection)
{
    Random random = new Random();
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = random.NextDouble() * 100;
        //collection[index] = Math.Round(collection[index], 2);-по желанию,можно округлить(числа более короткие будут 
        index ++;
    }
}

void PrintArray (double[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

void MaxMin (double[] col)
{
    double max = col[0];
    double min = col[0];
    double res = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if (col[i] > max) max = col[i];
        if (col[i] < min) min = col[i];
    }
    res = max - min;
    Console.WriteLine("Разница между max и min элементов массива равна:" + res);
}

double[] array = new double[5];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
MaxMin(array);