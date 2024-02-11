using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть перше число:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Введіть друге число:");
        string input2 = Console.ReadLine();

        if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
        {
            double sum = number1 + number2;
            Console.WriteLine($"Сума чисел {number1} та {number2} дорівнює: {sum}");
        }
        else
        {
            Console.WriteLine("Некоректне введення. Будь ласка, введіть числа.");
        }

        Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}
