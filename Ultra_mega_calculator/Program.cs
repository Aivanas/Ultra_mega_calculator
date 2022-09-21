Console.WriteLine("Добро пожаловать в мега мощный калькулятор. Разделяй и влавствуй!");
int choosed = 0;
int first_num = 0;
int second_num = 0;
Boolean bool_num = true;

do
{
    Console.WriteLine("Выберите что хотите сделать: ");
    Console.WriteLine("1. Сложить 2 числа\r\n2. Вычесть первое из второго\r\n3. Перемножить два числа\r\n4. Разделить первое на второе\r\n5. Возвести в степень N первое число\r\n6. Найти квадратный корень из числа\r\n7. Найти 1 процент от числа\r\n8. Найти факториал из числа\r\n9. Выйти из программы");
    Console.WriteLine("Что делать будем? (введите номер действия): ");
    choosed = Convert.ToInt32(Console.ReadLine());
    

    if (choosed == 1)
    {
        Console.WriteLine("Введите первое число: ");
        first_num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        second_num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат: " + (first_num + second_num));
        Console.WriteLine("----------------");
    }

    else if (choosed == 2)
    {
        Console.WriteLine("Введите первое число: ");
        first_num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        second_num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат: " + (second_num - first_num));
        Console.WriteLine("----------------");
    }

    else if (choosed == 3)
    {
        Console.WriteLine("Введите первое число: ");
        first_num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        second_num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат: " + (first_num * second_num));
        Console.WriteLine("----------------");
    }

    else if (choosed == 4)
    {
        Console.WriteLine("Введите первое число: ");
        first_num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        second_num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат: " + (first_num / second_num));
        Console.WriteLine("----------------");
    }

    else if (choosed == 5)
    {
        Console.WriteLine("Введите первое число: ");
        first_num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень числа: ");
        second_num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат: " + (Math.Pow(first_num, second_num)));
        Console.WriteLine("----------------");
    }

    else if (choosed == 6)
    {
        Console.WriteLine("Введите первое число: ");
        first_num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат: " + (Math.Sqrt(first_num)));
        Console.WriteLine("----------------");
    }

    else if (choosed == 7)
    {
        Console.WriteLine("Введите первое число: ");
        first_num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат: " + (first_num / 100));

        Console.WriteLine("----------------");
    }

    else if (choosed == 8)
    {
        Console.WriteLine("Введите первое число: ");
        first_num = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        int num = 1;
        while (num < first_num)
        {
            i++;
            num = num * i;

        }

        Console.WriteLine("Результат: " + i);
        Console.WriteLine("----------------");
    }

    else if (choosed == 9)
    {
        Console.WriteLine("Спасибо за использование кибер мощного калькулятора!");
        bool_num = false;
        Console.WriteLine("----------------");
    }

    else
    {
        Console.WriteLine("ГДЕ ТЫ ТУТ УВИДЕЛ ОПЕРАЦИЮ ПОД НОМЕРОМ "+ choosed+ " ?????????");
        Console.WriteLine("----------------");
    }
}
while (bool_num);