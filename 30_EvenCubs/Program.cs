// 30. Показать кубы чисел, заканчивающихся на четную цифру;

Console.Clear();
System.Console.WriteLine();

int N = new Random().Next(1, 10);
int number = 1;

System.Console.WriteLine($"N = {N}");

while (number <=N)
{
    int cube = number*number*number;
    if (number%2 == 0) System.Console.WriteLine(cube);
    number++;
}
