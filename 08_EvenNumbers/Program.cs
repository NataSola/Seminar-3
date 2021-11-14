// 8. Показать четные числа от 1 до N  

Console.Clear();

System.Console.Write("Введите число:   ");
string txtN = Console.ReadLine();
int endNum = Convert.ToInt32(txtN);
int num = 0;
System.Console.WriteLine($"Чётные числа из диапазона от 1 до {endNum}:");
while (num < endNum)
{
    num++;
    if (num % 2 == 0) System.Console.Write($"{num} ");
}
System.Console.WriteLine(); System.Console.WriteLine();