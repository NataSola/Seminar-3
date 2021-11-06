// 1. По двум введённым числам проверять является ли первое квадратом второго 
System.Console.WriteLine();
System.Console.WriteLine("Введите первое число: ");
string writeNumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(writeNumber1);

System.Console.WriteLine("Введите второе число: ");
string writeNumber2 = Console.ReadLine();
int number2 = Convert.ToInt32(writeNumber2);

string txtResult = $"Число {number1} не является квадратом числа {number2}";

if (number1 == number2 * number2) 
{
    txtResult = txtResult.Replace(" не", "");
}

System.Console.WriteLine(txtResult);
System.Console.WriteLine();
