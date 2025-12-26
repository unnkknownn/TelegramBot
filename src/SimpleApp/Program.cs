class Program

static void Main()

var calculator = new
Calculator();

Console.WriteLine("
калькулятор для уведомлений");

Console.WriteLine("

Простой

// Демонстрация работы
Console.WriteLine($"5 + 3 =
{calculator.Add(5, 3)}");
Console.WriteLine($"10 / 2 =
{calculator.Divide(10, 2)}");
Console.WriteLine($"7 npocToe
число? {calculator.IsPrime(7)}");
Console.WriteLine($"8 4eTHOe
число? {calculator.IsEven(8)}");

Console.WriteLine("\nV
Приложение готово к работе!");
Console.WriteLine("
Результаты будут отправлены в
Telegram!");