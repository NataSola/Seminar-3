// 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел
Console.Clear();
System.Console.WriteLine();

int size = 20;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintResult(int[] array)
{
    int even = 0;
    int uneven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) even++;
        else uneven++;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество четных чисел {even}, количество нечетных чисел {uneven}");
    System.Console.WriteLine();
}

PrintResult(FillArray(size));



// int[] CountEvenUneven(int[] array)                   // Это оказалось не нужным, но пусть пока будет
// {
//     int[] evenUneven = new int[2];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) evenUneven[0]++;
//         else evenUneven[1]++;
//     }
//     return evenUneven;
// }