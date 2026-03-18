
double result;
string? input1;
string? input2;
double number1 = 0;
double number2 = 0;

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
        //Ввод первого числа
        Console.WriteLine("Введите первое число: ");
        input1 = Console.ReadLine();

        if (!double.TryParse(input1, out number1))
        {
            Console.WriteLine("Ошибка! Это не число. Программа завершена.");
            return;
        }
        //Ввод второго числа
        Console.WriteLine("Введите второе число");
        input2 = Console.ReadLine();
        if (!double.TryParse(input2, out number2))
        {
            Console.WriteLine("Ошибка! Это не число. Программа завершена.");
            return;
        }
        //Вычисление операции (сложение)
        result = number1 + number2;
        Console.WriteLine($"{number1} + {number2} = {result}");
        break;


    case "2": 
        Console.WriteLine("Вы выбрали операцию отрицания");
        //Ввод первого числа
        Console.WriteLine("Введите первое число: ");
        input1 = Console.ReadLine();
        if (!double.TryParse(input1, out number1))
        {
            Console.WriteLine("Ошибка! Это не число. Программа завершена.");
            return;
        }
        //Ввод второго числа
        Console.WriteLine("Введите второе число");
        input2 = Console.ReadLine();
        if (!double.TryParse(input2, out number2))
        {
            Console.WriteLine("Ошибка! Это не число. Программа завершена.");
            return;
        }
        //Вычисление операции (отрицание)
        if (number1 > number2)
        {
            result = number1 - number2;
            Console.WriteLine($"{number1} - {number2} = {result}");
        }
        else
        {
            result = number2 - number1;
            Console.WriteLine($"{number2} - {number1} = {result}");
        }
        break;
    case "3":
        Console.WriteLine("Вы выбрали операцию умножения");
        //Ввод первого числа
        Console.WriteLine("Введите первое число");
        input1 = Console.ReadLine();
        if (!double .TryParse(input1, out number1))
        {
            Console.WriteLine("Ошибка! Это не число. Программа завершена");
            return;
        }
        //Ввод второго числа
        Console.WriteLine("Введите второе число");
        input2 = Console.ReadLine();
        if(! double .TryParse(input2, out number2))
        {
            Console.WriteLine("Ошибка! Это не числор. Программа завершена");
            return;
        }
        //Вычисление операции (умножение)
        result = number1 * number2;
        Console.WriteLine($"{number1} * {number2} = {result}");
        break;
    case "4":
        Console.WriteLine("Вы выбрали операцию деления");
        //Ввод первого числа
        Console.WriteLine("Введите первое число");
        input1 = Console.ReadLine();
        if (!double .TryParse (input1, out number1))
        {
            Console.WriteLine("Ошибка! Это не число. Программа завершена");
            return;
        }
        //Ввод второго числа
        Console.WriteLine("Введите второе число");
        input2 = Console.ReadLine();
        if (! double .TryParse(input2, out number2))
        {
            Console.WriteLine("Ошибка! Это не число. Программа завершена");
            return;
        }
        //Вычисление операции (деление)
        if (number2 != 0)
        {
            result = number1 / number2;
            Console.WriteLine($"{number1} / {number2} = {result}");
        }
        else
        {
            Console.WriteLine("На ноль делить нельзя");
        }
        break;
    default:
        Console.WriteLine("Такой операции не существует");
        break;
}
