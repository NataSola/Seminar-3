// 21. Программа проверяет пятизначное число на палиндромом.

// Задача решена двумя способами для любого целого числа

// первый способ 

Console.Clear();
System.Console.WriteLine();

System.Console.Write("Введите целое число:   ");
string number = Console.ReadLine();
int length = number.Length;
string txtToCheck = number.Replace(" ","");  /// для проверки текста на палиндром

bool IsPalindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}

System.Console.WriteLine("Ответ при решении первым способом:");
if (IsPalindrome()) System.Console.WriteLine($"1. Введный текст/число - {number} - является палиндромом");
else System.Console.WriteLine($"1. Число {number} не является палиндромом");
System.Console.WriteLine();


// / второй способ    -- ограничено девятизначными числами

int dev1 = 1;
int dev2 = 10;
int num = Convert.ToInt32(number);

for (int i = 0; i < length - 1; i++)
{
    dev1 = dev1 * 10;
}

bool IsPalindrome2()
{
    int numFirst = num / dev1;
    int numSecond = num % dev2;
    while (numFirst == numSecond)
    {
        return true;
        dev1 = dev1 / 10;
        dev2 = dev2 * 10;
    }
    return false;
}

System.Console.WriteLine("Ответ при решении вторым способом:");
if (IsPalindrome2()) System.Console.WriteLine($"2. Число {number} является палиндромом");
else System.Console.WriteLine($"2. Число {number} не является палиндромом");
System.Console.WriteLine();