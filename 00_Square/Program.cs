// 0. Вывести квадрат числа  

// Вариант 1. Считаем через переменную

int number1 = new Random().Next(1, 100);
int result = number1 * number1;
System.Console.WriteLine($"1. Квадрат числа {number1} = {result}");


// Вариант 2. Сразу выводим результат 

int number2 = new Random().Next(1, 100);
System.Console.WriteLine($"2. Квадрат числа {number2} = {number2 * number2}");


// Вариант 3. Ввод числа с клавиатуры

System.Console.WriteLine("Введите число: ");
string writeNumber = Console.ReadLine();
int number3 = Convert.ToInt32(writeNumber);
System.Console.WriteLine($"3. Квадрат числа {number3} = {number3 * number3}");