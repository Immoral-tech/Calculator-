
double result = 0;
string? input;
double number = 0;
double temp = 0;
bool flag = true;
bool flagchoice = true;



while (flagchoice == true)
{
    Console.WriteLine("Выберите операцию: ");
    Console.WriteLine("1 - Сложение (+)");
    Console.WriteLine("2 - Вычитание (-)");
    Console.WriteLine("3 - Умножение (*)");
    Console.WriteLine("4 - Деление (/)");
    Console.WriteLine("Ваш выбор (1-4): ");
    Console.WriteLine("Для выхода - exit");
    string? operationchoice = Console.ReadLine();
    flag = true;
    switch (operationchoice)
    {
        case "1":
            Console.WriteLine("Вы выбрали операцию сложения");
            Console.WriteLine("Для остановки сложения введите: 00");
            Console.Write("Введите число для сложения: ");
            input = Console.ReadLine();
            if (!double.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка. Это не число");
            }
            while (flag == true)
            {
                if (number != 00)
                {
                    result += number;
                    Console.WriteLine($"Результат сложения: {result}");
                    Console.WriteLine("Введите число для сложения");
                    input = Console.ReadLine();
                    if (!double.TryParse(input, out number))
                    {
                        Console.WriteLine("Ошибка. Это не число");
                    }
                }
                if (number == 00)
                {
                    flag = false;
                    Console.WriteLine("Вы вышли из умножения");
                }
            }
            break;
        case "2":
            Console.WriteLine("Вы выбрали операцию вычитания");
            Console.WriteLine("Для остановки сложения введите: 00");
            Console.Write("Введите число для вычитания: ");
            input = Console.ReadLine();
            if (!double.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка. Это не число");
            }
            while (flag == true)
            {
                if (number != 00)
                {
                    result -= number;
                    Console.WriteLine($"Результат вычитания: {result}");
                    Console.WriteLine($"Введите число для вычитания из числа {result}");
                    input = Console.ReadLine();
                    if (!double.TryParse(input, out number))
                    {
                        Console.WriteLine("Ошибка. Это не число");
                    }
                }
                if (number == 00)
                {
                    flag = false;
                    Console.WriteLine("Вы вышли из умножения");
                }
            }

            break;
        case "3":
            { 
            result = 1;
            Console.WriteLine("Вы выбрали операцию умножения");
            Console.WriteLine("Для остановки сложения введите: 00");
            Console.Write("Введите число для умножения: ");
            input = Console.ReadLine();
            if (!double.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка. Это не число");
            }
                while (flag == true)
                {
                    if (number != 00)
                    {
                        result *= number;
                        Console.WriteLine($"Результат умножения: {result}");
                        Console.WriteLine("Введите число для умножения");
                        input = Console.ReadLine();
                        if (!double.TryParse(input, out number))
                        {
                            Console.WriteLine("Ошибка. Это не число");
                        }
                    }
                    if (number == 00)
                    {
                        flag = false;
                        Console.WriteLine("Вы вышли из умножения");
                    }
                }
            }
            break;
        case "4":
            Console.WriteLine("Вы выбрали операцию деления");
            Console.WriteLine("Для остановки деления введите: 00");
            Console.Write("Введите число (делимое): ");
            input = Console.ReadLine();
            if (!double.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка. Это не число");
            }
            temp = number;
            while (flag == true)
            {
                if (number != 00)
                {
                    Console.WriteLine("Введите число (делитель)");
                    input = Console.ReadLine();
                    if (!double.TryParse(input, out number))
                    {
                        Console.WriteLine("Ошибка. Это не число");
                    }
                    result = temp / number;
                    Console.WriteLine($"Результат деления: {result}");
                   
                }
                if (number == 00)
                {
                    flag = false;
                    Console.WriteLine("Вы вышли из умножения");
                }
            }
            break;
        case "exit":
            {
                Console.WriteLine("Вы вышли из программы");
                flagchoice = false;
                break;
            }
        default:
            Console.WriteLine("Такой операции не существует");
            Console.WriteLine("Проверьте корректность ввода");
            break;
    }
}
Console.WriteLine("Выход из программы...");