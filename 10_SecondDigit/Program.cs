// 10. Показать вторую цифру трёхзначного числа

Console.Clear();
System.Console.WriteLine();
int number = new Random().Next(100, 1000);

System.Console.WriteLine($"Второй цифрой числа {number} является {number / 10 % 10} ");

System.Console.WriteLine(); 