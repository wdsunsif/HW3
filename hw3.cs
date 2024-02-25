
//1
/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число от 1 до 100:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number < 1 || number > 100)
            {
                Console.WriteLine("Ошибка");
            }
            else
            {
                if (number % 3 == 0 && number % 5 == 0)
                    Console.WriteLine("Fizz Buzz");
                else if (number % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (number % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
    }
}
*/


//2
/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        if (double.TryParse(Console.ReadLine(), out double value))
        {
            Console.WriteLine("Введите процент:");
            if (double.TryParse(Console.ReadLine(), out double percent))
            {
                double result = value * (percent / 100);
                Console.WriteLine($"Результат: {result}");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
    }
}
*/


//3
/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите четыре цифры:");
        string input = Console.ReadLine();
        if (input.Length == 4 && int.TryParse(input, out int number))
        {
            Console.WriteLine($"Результат: {number}");
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
    }
}
*/

//4
/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите шестизначное число:");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number >= 100000 && number <= 999999)
            {
                Console.WriteLine("Введите номера разрядов для обмена");
                string[] positions = Console.ReadLine().Split(' ');
                if (positions.Length == 2 && int.TryParse(positions[0], out int position1) && int.TryParse(positions[1], out int position2))
                {
                    if (position1 >= 1 && position1 <= 6 && position2 >= 1 && position2 <= 6)
                    {
                        char[] digits = number.ToString().ToCharArray();
                        char temp = digits[position1 - 1];
                        digits[position1 - 1] = digits[position2 - 1];
                        digits[position2 - 1] = temp;
                        Console.WriteLine($"Результат: {new string(digits)}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
    }
}
*/

//5
/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите дату :");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime date))
        {
            string season = GetSeason(date.Month);
            string dayOfWeek = date.DayOfWeek.ToString();
            Console.WriteLine($"Результат: {season} {dayOfWeek}");
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
    }

    static string GetSeason(int month)
    {
        if (month == 12 || month <= 2)
            return "Winter";
        else if (month >= 3 && month <= 5)
            return "Spring";
        else if (month >= 6 && month <= 8)
            return "Summer";
        else
            return "Autumn";
    }
}*/


//6
/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите температуру:");
        if (double.TryParse(Console.ReadLine(), out double temperature))
        {
            Console.WriteLine("Выберите единицы измерения:");
            string choice = Console.ReadLine();
            if (choice.ToUpper() == "F")
            {
                double celsius = FahrenheitToCelsius(temperature);
                Console.WriteLine($"Температура по Цельсию: {celsius}");
            }
            else if (choice.ToUpper() == "C")
            {
                double fahrenheit = CelsiusToFahrenheit(temperature);
                Console.WriteLine($"Температура по Фаренгейту: {fahrenheit}");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }
}
*/


//7
/*
class Program
{
    static void Main(string[] args)
    {
        int start, end;
        Console.WriteLine("Введите начало и конец диапазона:");
        do
        {
            Console.Write("Начало: ");
            string startInput = Console.ReadLine();
            if (!int.TryParse(startInput, out start))
            {
                Console.WriteLine("Ошибк");
                continue;
            }
            Console.Write("Конец: ");
            string endInput = Console.ReadLine();
            if (!int.TryParse(endInput, out end))
            {
                Console.WriteLine("Ошбак");
                continue;
            }
            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }
            break;

        } while (true);
        Console.WriteLine($"Четные числа в диапазоне от {start} до {end}:");
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
*/
