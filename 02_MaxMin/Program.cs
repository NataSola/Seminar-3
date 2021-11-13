// 2. Даны два числа. Показать большее и меньшее число 

System.Console.WriteLine();

string[] txtNumber = { "первое", "второе" };
int[] number = new int[2];

for (int i = 0; i < 2; i++)
{
    System.Console.WriteLine($"Введите {txtNumber[i]} число:");
    string writeNumber = Console.ReadLine();
    number[i] = Convert.ToInt32(writeNumber);
}
int max = number.Max();
int min = number.Min();

if (max == min) System.Console.WriteLine("Введённые числа равны");
else 
{
    System.Console.WriteLine($"Большее число {max}, меньшее число {min}");
}
System.Console.WriteLine();