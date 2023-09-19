using System;
double CalculateFactorial(double number)
{
    double factorial = 1; // Вычисление факториала числа
    for (int i = 1; i <= number; i++)
    {
        factorial *= i;
    }
    return factorial;
}
double res = 0.0;
double number1, number2;
int chop;
do
{
    // Выводим меню операций
    Console.WriteLine("Выберите операцию из представленных ниже:"); Console.WriteLine("1) Сложение"); Console.WriteLine("2) Вычетание"); Console.WriteLine("3) Умножение");
    Console.WriteLine("4) Деление"); Console.WriteLine("5) Возвести в степень"); Console.WriteLine("6) Найти квадратный корень из числа"); Console.WriteLine("7) Найти 1% от числа");
    Console.WriteLine("8) Найти факториал"); Console.WriteLine("9) Exit");
    Console.Write("Введите номер операции который вы выбрали: "); // Запрашиваем выбор операции от пользователя
    if (!int.TryParse(Console.ReadLine(), out chop))
    {
        Console.WriteLine("Ошибка: Неправильно выбрана операция. Пожалуйста, введите номер операции (число).");
        continue;
    }
    switch (chop)
    {
        case 1:
            Console.Write("Введите первое число: "); // Запрашиваем числа и выполняем операцию сложения
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            number2 = double.Parse(Console.ReadLine());
            res = number1 + number2;
            Console.WriteLine($"Окончательный результат: {res}");
            break;
        case 2:
            Console.Write("Введите первое число: "); // Запрашиваем числа и выполняем операцию вычитания
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            number2 = double.Parse(Console.ReadLine());
            res = number1 - number2;
            Console.WriteLine($"Окончательный результат: {res}");
            break;
        case 3:
            Console.Write("Введите первое число: "); // Запрашиваем числа и выполняем операцию умножения
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            number2 = double.Parse(Console.ReadLine());
            res = number1 * number2;
            Console.WriteLine($"Окончательный результат: {res}");
            break;
        case 4:
            Console.Write("Введите первое число: "); // Запрашиваем числа и выполняем операцию деления, обрабатывая деление на ноль
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            number2 = double.Parse(Console.ReadLine());
            if (number2 != 0)
            {
                res = number1 / number2;
                Console.WriteLine($"Окончательный результат: {res}");
            }
            else
            {
                Console.WriteLine("Ошибка: Вы что забыли что нельзя делить на ноль.");
            }
            break;
        case 5:
            Console.Write("Введите число: "); // Запрашиваем число и степень, затем выполняем операцию возведения в степень
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Введите степень: ");
            int power = int.Parse(Console.ReadLine());
            res = Math.Pow(number1, power);
            Console.WriteLine($"Окончательный результат: {res}");
            break;
        case 6:
            Console.Write("Введите число: "); // Запрашиваем число и выполняем операцию нахождения квадратного корня
            number1 = double.Parse(Console.ReadLine());
            res = Math.Sqrt(number1);
            Console.WriteLine($"Окончательный результат: {res}");
            break;
        case 7:
            Console.Write("Введите число: "); // Запрашиваем число и выполняем операцию нахождения 1 процента
            number1 = double.Parse(Console.ReadLine());
            res = 0.01 * number1;
            Console.WriteLine($"1% числа: {res}");
            break;
        case 8:
            Console.Write("Введите число: "); // Запрашиваем число и выполняем операцию нахождения факториала
            number1 = double.Parse(Console.ReadLine());
            res = CalculateFactorial(number1);
            Console.WriteLine($"Факториал числа: {res}");
            break;
        case 9:
            Console.WriteLine("Калькулятор устал работать. Спасибо что завершили его работу.");
            break;
        default:
            Console.WriteLine("Неправильно. Попробуйте еще раз.");
            break;
    }
} while (chop != 9);