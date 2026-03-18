
double result;
string? input1;
string? input2;
double number1 = 0;
double number2;

Console.WriteLine("Выберите операцию: ");
Console.WriteLine("1 - Сложение (+)");
Console.WriteLine("2 - Вычитание (-)");
Console.WriteLine("3 - Умножение (*)");
Console.WriteLine("4 - Деление (/)");
Console.WriteLine("Ваш выбор (1-4): ");


string? operationchoice = Console.ReadLine();
switch (operationchoice)
{
    case "1":
        Console.WriteLine("Вы выбрали операцию сложения");
        Console.WriteLine("Введите первое число: ");

        input1 = Console.ReadLine();
        number1 = 0;

        if (!double.TryParse(input1, out number1))
        {
            Console.WriteLine("Ошибка! Это не число. Программа завершена.");
            return;
        }

        //Ввод второго числа
        Console.WriteLine("Введите второе число");
        input2 = Console.ReadLine();
        number2 = 0;
        if (!double.TryParse(input2, out number2))
        {
            Console.WriteLine("Ошибка! Это не число. Программа завершена.");
            return;
        }

        result = number1 + number2;
        Console.WriteLine($"{number1} + {number2} = {result}");
        break;
    case "2": Console.WriteLine("Вы выбрали операцию отрицания");
        input1 = Console.ReadLine();
        number1 = 0;

        if (!double.TryParse(input1, out number1))
        {
            Console.WriteLine("Ошибка! Это не число. Программа завершена.");
            return;
        }

        //Ввод второго числа
        Console.WriteLine("Введите второе число");
        input2 = Console.ReadLine();

        if (!double.TryParse(input2, out double number2))
        {
            Console.WriteLine("Ошибка! Это не число. Программа завершена.");
            return;
        }
        break;
    default:
        Console.WriteLine("Такой операции не существует");
        break;
}
