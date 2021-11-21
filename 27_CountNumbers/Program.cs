// 27. Определить количество цифр в числе

Console.Clear();
System.Console.WriteLine();

System.Console.Write("Введите число:   ");
string writeNum = Console.ReadLine();
int number = Convert.ToInt32(writeNum);
int result = number;

// первый способ

int count1 = 0;
while (result > 0)
{
    result = result / 10;
    count1++;
}
System.Console.WriteLine("Первый способ:");
System.Console.WriteLine($"В числе {number} {count1} цифр");
System.Console.WriteLine();

// второй способ

System.Console.WriteLine("Второй способ:");
int count2 = 0;
for (result = number; result > 0; count2++) result = result /10;

System.Console.WriteLine($"В числе {number} {count2} цифр");