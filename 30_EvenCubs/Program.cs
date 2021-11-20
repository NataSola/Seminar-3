// 30. Показать кубы чисел, заканчивающихся на четную цифру;

Console.Clear();
System.Console.WriteLine();

int N = new Random().Next(1, 20);
int number = 1;
System.Console.WriteLine($"N = {N}");

while (number <= N)
{
    int cube = number * number * number;
    if (cube % 2 == 0) System.Console.Write(cube + " ");
    number++;
}
System.Console.WriteLine();

// решение через метод

int[] GetEvenCubeArray(int N)
{
    int num = 1;
    int i = 0;
    int[] EvenCubs = new int[N];
    while (num <= N)
    {
        int cube = num * num * num;
        if (cube % 2 == 0)
        {
            EvenCubs[i] = cube;
            i++;
        }
        num++;
    }
    return EvenCubs;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("By Method:");

PrintArray(GetEvenCubeArray(N));