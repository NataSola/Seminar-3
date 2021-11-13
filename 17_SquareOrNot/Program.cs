// 17. По двум заданным числам проверять является ли одно квадратом другого

// !!! ПОВТОР ЗАДАЧИ № 2 !!!

Console.Clear();
System.Console.WriteLine();

int[] num = new int[2];
string Result = "не является";

for (int i = 0; i < 2; i++)
{
    num[i] = new Random().Next(1, 1000);
}

if (num[0] / num[1] == num[1]) Result = Result.Replace("не ", "");

System.Console.WriteLine($"Число {num[0]} {Result} квадратом числа {num[1]}");
System.Console.WriteLine();