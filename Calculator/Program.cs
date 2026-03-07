#include <math.h>

Console.WriteLine("Первая пограмма на C#");
Console.WriteLine("Консольный калькулятор");
Console.WriteLine();

//Ввод первого числа
Console.WriteLine("Введите первое число: ");
string? input1 = Console.ReadLine();
double number1 = 0;

if (!double.TryParse(input1, out number1))
{
    Console.WriteLine("Ошибка! Это не число. Программа завершена.");
    return;
}

//Ввод второго числа
Console.WriteLine("Введите второе число");
string? input2 = Console.ReadLine();

if (!double.TryParse(input2, out double number2))
{
    Console.WriteLine("Ошибка! Это не число. Программа завершена.");
    return;
}

//Ввод операций
Console.WriteLine("Выберите операцию: ");
Console.WriteLine("1 - Сложение (+)");
Console.WriteLine("2 - Вычитание (-)");
Console.WriteLine("3 - Умножение (*)");
Console.WriteLine("4 - Деление (/)");
Console.WriteLine("Ваш выбор (1-4): ");

string? operationChoice = Console.ReadLine();

//Выполнение операции
double result = 0;
bool validOperation = true;

if (operationChoice == "1")
{
    result = number1 + number2;
    Console.WriteLine($"{number1} + {number2} = {result}");
}

else if (operationChoice == "2")
{
    result = number1 - number2;
    Console.WriteLine($"{number1} - {number2} = {result}");
}

else if (operationChoice == "3")
{
    result = number1 * number2;
    Console.WriteLine($"{number1} * {number2} = {result}");
}

else if (operationChoice == "4")
{
    Console.WriteLine("Выберите число для возведения в степень");
    Console.Writeline("1 или 2");
    string? input3 = Console.ReadLine();
    double numberchoice = 0;
    if (!double.TryParse(input3, out numberchoice))
    {
        Console.WriteLine("Это не число");
        return;
    }
    if (numberchoice = "1")
    {
        Console.WriteLine("Введите степень для возведения");
        int count = int.Parse(Console.ReadLine());
        result = pow(number1,count);
        Console.WriteLine($"{number1} ^ {count} = {result}"
    }
    else
    {
        Console.WriteLine("Введите степень для возведения");
        int count = int.Parse(Console.ReadLine());
        result = pow(number2,count);
        Console.WriteLine($"{number2} ^ {count} = {result}");
    }
}

else if (operationChoice == "5")
{
    if (number2 != 0)
    {
        result = number1 / number2;
        Console.WriteLine($"{number1} / {number2} = {result}");
    }
    else
    {
        Console.WriteLine("Ошибка! Деление на ноль невозможно.");
        validOperation = false;
    }
}

else
{
    Console.WriteLine("Ошибка! Неверный выбор операции.");
    validOperation = false;

}

//Итоговое сообщение
if (validOperation)
{
    Console.WriteLine("Операция выполнена успешно!");
}
else
{
    Console.WriteLine("Не удалось выполнить операцию.");
}

Console.WriteLine("Нажмите любую клавишу для выхода...");
Console.ReadKey();
