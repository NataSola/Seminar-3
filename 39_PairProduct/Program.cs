// 39. Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Clear();
System.Console.WriteLine();

int size = new Random().Next(10, 26);
int min = 1;
int max = 100;
System.Console.WriteLine($"Количество элементов массива: {size}");

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

// первый вариант - собираем новый массив из произведений пар.
// В случае, если количество элементов исходного массива нечетное, среднее значение массива "выпадает" из обработки

int[] GetPairProduct(int[] data)
{
    int[] product = new int[data.Length / 2];
    int last = data.Length - 1;
    for (int i = 0; i < data.Length / 2; i++)
    {
        product[i] = data[i] * data[last];
        last = last - 1;
    }
    return product;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}

int[] array = FillArray(size, min, max);
PrintArray(array);

System.Console.WriteLine();
System.Console.WriteLine("Первый вариант:");
PrintArray(GetPairProduct(array));

// воторой вариант с выводом среднего числа (если количество элементов массива нечетное)

void PrintProductPairs(int[] dataArray)
{
    int last = dataArray.Length - 1;
    for (int i = 0; i < dataArray.Length / 2; i++)
    {
        System.Console.WriteLine($"{dataArray[i]} x {dataArray[last]} = {dataArray[i] * dataArray[last]} ");
        last--;
    }
    if (dataArray.Length % 2 > 0) System.Console.WriteLine($"Число {dataArray[dataArray.Length / 2]} не имеет пары");
    System.Console.WriteLine();
}
System.Console.WriteLine();
System.Console.WriteLine("Второй вариант:");
PrintProductPairs(array);