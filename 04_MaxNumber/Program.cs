// 4. Найти максимальное из трех чисел 

int[] Numbers = { 54, 65, 3 };

for (int i = 0; i < 3; i++)
{
    int max = Numbers[0];
    
    if (Numbers[i] > max)
    {
        max = Numbers[i];
        System.Console.WriteLine();
        System.Console.WriteLine($"Максимальное число {max}");
    }
}
System.Console.WriteLine();

