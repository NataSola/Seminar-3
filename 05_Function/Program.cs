// Написать программу вычисления значения функции y=f(a)

// Вывести N-е число последовательности Фибоначчи

System.Console.WriteLine();
System.Console.Write("Введите число:    ");
string writeNumber1 = Console.ReadLine();
int n = Convert.ToInt32(writeNumber1);

int previous1 = 1;
int previous2 = 1;
int FibonacciNumber = 0;
int count = 0;
System.Console.WriteLine($"Последовательность Фибоначчи: ");
System.Console.Write($"{previous1}  {previous2}  ");


while (count <= n)
{
    FibonacciNumber = previous1 + previous2;
    previous2 = previous1;
    previous1 = FibonacciNumber;
    count++;
    System.Console.Write($"{FibonacciNumber}  ");
}
System.Console.WriteLine(); System.Console.WriteLine();

System.Console.WriteLine($"{n}-м числом Фибоначчи является: {FibonacciNumber}");
System.Console.WriteLine();