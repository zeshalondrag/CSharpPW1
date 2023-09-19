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
double result = 0.0;
double number1, number2;
int choice;
do
{
    // Выводим меню операций
    Console.WriteLine("Выберите операцию из представленных ниже:"); Console.WriteLine("1) Сложение"); Console.WriteLine("2) Вычетание"); Console.WriteLine("3) Умножение");
    Console.WriteLine("4) Деление"); Console.WriteLine("5) Возвести в степень"); Console.WriteLine("6) Найти квадратный корень из числа"); Console.WriteLine("7) Найти 1% от числа");
    Console.WriteLine("8) Найти факториал"); Console.WriteLine("9) Exit");
    Console.Write("Введите номер операции который вы выбрали: "); // Запрашиваем выбор операции от пользователя
    choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.Write("Введите первое число: "); // Запрашиваем числа и выполняем операцию сложения
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            number2 = double.Parse(Console.ReadLine());
            result = number1 + number2;
            Console.WriteLine($"Окончательный результат: {result}");
            break;
        case 2:
            Console.Write("Введите первое число: "); // Запрашиваем числа и выполняем операцию вычитания
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            number2 = double.Parse(Console.ReadLine());
            result = number1 - number2;
            Console.WriteLine($"Окончательный результат: {result}");
            break;
        case 3:
            Console.Write("Введите первое число: "); // Запрашиваем числа и выполняем операцию умножения
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            number2 = double.Parse(Console.ReadLine());
            result = number1 * number2;
            Console.WriteLine($"Окончательный результат: {result}");
            break;
        case 4:
            Console.Write("Введите первое число: "); // Запрашиваем числа и выполняем операцию деления, обрабатывая деление на ноль
            number1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            number2 = double.Parse(Console.ReadLine());
            if (number2 != 0)
            {
                result = number1 / number2;
                Console.WriteLine($"Окончательный результат: {result}");
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
            result = Math.Pow(number1, power);
            Console.WriteLine($"Окончательный результат: {result}");
            break;
        case 6:
            Console.Write("Введите число: "); // Запрашиваем число и выполняем операцию нахождения квадратного корня
            number1 = double.Parse(Console.ReadLine());
            result = Math.Sqrt(number1);
            Console.WriteLine($"Окончательный результат: {result}");
            break;
        case 7:
            Console.Write("Введите число: "); // Запрашиваем число и выполняем операцию нахождения 1 процента
            number1 = double.Parse(Console.ReadLine());
            result = 0.01 * number1;
            Console.WriteLine($"1% числа: {result}");
            break;
        case 8:
            Console.Write("Введите число: "); // Запрашиваем число и выполняем операцию нахождения факториала
            number1 = double.Parse(Console.ReadLine());
            result = CalculateFactorial(number1);
            Console.WriteLine($"Факториал числа: {result}");
            break;
        case 9:
            Console.WriteLine("Калькулятор устал работать. Спасибо что завершили его работу.");
            break;
        default:
            Console.WriteLine("Неправильно. Попробуйте еще раз.");
            break;
    }
} while (choice != 9);