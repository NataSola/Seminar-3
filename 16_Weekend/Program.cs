// 16. Дано число, обозначающее день недели. Выяснить, является номер дня недели выходным

Console.Clear();
System.Console.WriteLine();

int dayNumber = new Random().Next(1, 8);
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string txtResult = "";

if (dayNumber > 5) txtResult = $". Ура! Это выходной день!";
else txtResult = $", рабочий день.";

System.Console.WriteLine();
System.Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]}{txtResult}");
System.Console.WriteLine();