// 1. По двум введённым числам проверять является ли первое квадратом второго 

// Первый способ

System.Console.WriteLine("Первый способ:");
System.Console.WriteLine("Введите первое число: ");
string writeNumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(writeNumber1);

System.Console.WriteLine("Введите второе число: ");
string writeNumber2 = Console.ReadLine();
int number2 = Convert.ToInt32(writeNumber2);

string txtResult = $"Число {number1} не является квадратом числа {number2}";     // вывод результата проверки на экран

if (number1 == number2 * number2)               // можно записать (number1 / number2 == number2)
{
    txtResult = txtResult.Replace(" не", "");   // если условие выполняется, то частица "не" заменяется пустым значением
}
System.Console.WriteLine(txtResult);
System.Console.WriteLine();

// Второй способ

System.Console.WriteLine("Второй способ:");

int i = 0;
string[] nums = { "первое", "воторое" };
int[] num = new int[2];
string Result = "не является";

for (i = 0; i < 2; i++)
{
    System.Console.WriteLine($"Введите {nums[i]} число: ");
    string writeNum = Console.ReadLine();
    num[i] = Convert.ToInt32(writeNum);
}

if (num[0] / num[1] == num[1]) Result = Result.Replace("не ", "");

System.Console.WriteLine($"Число {num[0]} {Result} квадратом числа {num[1]}");