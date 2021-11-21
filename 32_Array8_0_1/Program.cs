// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int N = 8;
int min = 0;
int max = 1;

int[] CreateArray(int N, int min, int max)
{
    int[] arr = new int[N];
    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

PrintArray(CreateArray(N, min, max));