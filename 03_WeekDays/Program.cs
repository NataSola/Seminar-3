// 3. По введенному номеру дня недели вывести его название

System.Console.WriteLine();
string[] Days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

System.Console.Write("Введите номер дня недели:   ");
string writeDay = Console.ReadLine();
bool result = int.TryParse(writeDay, out int dayNumber);

System.Console.WriteLine();
if (result == false) System.Console.WriteLine("Число введено неверно");
else if (0 < dayNumber && dayNumber < 8) System.Console.WriteLine($"{dayNumber}-й день недели - {Days[dayNumber - 1]}");
else System.Console.WriteLine("Дня недели с таким номером не существует");
System.Console.WriteLine();
