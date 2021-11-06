// 3. По введенному номеру дня недели вывести его название

System.Console.WriteLine();
string[] Days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

// int dayNumber = new Random().Next(1,8);

System.Console.Write("Введите номер дня недели:   ");
string writeDay = Console.ReadLine();

int i = 0;
bool result = int.TryParse(writeDay, out int dayNumber);
// int dayNumber = Convert.ToInt32(writeDay);

if (result == false) System.Console.WriteLine("Число введено неверно");
else
{
    if (0 < dayNumber && dayNumber < 8) System.Console.WriteLine($"{dayNumber}-й день недели - {Days[dayNumber - 1]}");
    else
    {
        System.Console.WriteLine("Дня недели с таким номером не существует");
    }
}

System.Console.WriteLine();