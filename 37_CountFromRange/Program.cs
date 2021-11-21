// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int size = 123;
int min = -100;
int max = 200;

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintCountArray(int[] arr)
{
    int count = 1;
    System.Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
        if (arr[i] >= 10 && arr[i] <= 99) count++;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество чисел из диапазона [10, 99] равно {count}");
    System.Console.WriteLine();
}

PrintCountArray(FillArray(size, min, max));