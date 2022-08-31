// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

void EvenNumbersArray (int n) {

    int[] arr = new int[n];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();

    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0 )
        {
            count += 1;
        
        }
        
    }
    Console.WriteLine("В массиве чётных чисел:" + count); 
    
}    

EvenNumbersArray(7);


