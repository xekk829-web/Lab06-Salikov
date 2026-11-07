// // Задание 1.1
// for (int i = 10; i >= 1; i--)
// {
//     Console.WriteLine(i);
// }

// // Задание 1.2
// Console.Write("|");
// for (int i = 2; i <= 50; i += 2)
// {
//     Console.Write($" {i} |");
// }
// Console.WriteLine();

// // Задание 2
// int sumMultiple3 = 0;
// int counterDivisibleBy7 = 0;
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0)
//     {
//         sumMultiple3 += i;
//     }

//     if (i % 7 == 0)
//     {
//         counterDivisibleBy7++;
//     }
// }
// Console.WriteLine($"Сумма чисел, которые делятся на 3: {sumMultiple3} | Сумма чисел, которые делятся на 7: {counterDivisibleBy7}");

// // Задание 3
// int number = Convert.ToInt32(Console.ReadLine());
// int totalPositive = 0;
// int totalNegative = 0;

// while (number != 0)
// {
//     if (number > 0)
//     {
//         totalPositive++;
//     }
//     else
//     {
//         totalNegative++;
//     }

//     Console.WriteLine($"Введено: {totalPositive} положительных и {totalNegative} отрицательных чисел");
//     number = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine("Вы ввели 0");

// // Задание 4
// string password;
// int attempts = 3;
// do
// {
//     Console.Write("Введите пароль: ");
//     password = Console.ReadLine();
//     attempts--;
// } while (password != "qwerty" && attempts > 0);

// string text = attempts == 0 && password != "qwerty" ? "заблокирован" : "разрешён";
// Console.WriteLine($"Доступ {text}");

// // Задание 5
// bool flag = false;
// while (flag == false)
// {
//     Console.Write("Введите число от 1 до 10: ");
//     int n = Convert.ToInt32(Console.ReadLine());

//     if (n <= 10 && n > 0)
//     {
//         for (int i = 1; i <= 10; i++)
//         {
//             Console.WriteLine($"{n} x {i} = {n * i}");
//         }
//         flag = true;
//     }
//     else
//     {
//         Console.WriteLine("Введено неккоректное значение");
//     }
// }

// // Задание 6
// for (int i = 1; i <= 30; i++)
// {
//     if (i % 3 == 0) continue;
//     if (i % 10 == 0 && i > 20) break;

//     Console.WriteLine(i);
// }

// Итоговая задача. «Угадай число»

Random random = new Random();
bool flag = true;
bool flag2 = false;
while (flag == true)
{
    int secret = random.Next(1, 100);
    Console.WriteLine("Загадано число от 1 до 100, угадай его");
    int attempts = 5;
    while (attempts > 0)
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > secret)
        {
            Console.WriteLine("Меньше");
        }
        else if (num < secret)
        {
            Console.WriteLine("Больше");
        }
        else
        {
            Console.WriteLine($"ПОБЕДА! ВЫ УГАДАЛИ ЧИСЛО {secret}!");
            flag2 = true;
            break;
        }
        attempts--;
    }
    if (attempts == 0 && flag2 == false)
    {
        Console.WriteLine($"Вы проиграли! Было загадано число {secret}");
    }
    Console.Write("Сыграть ещё раз? (да/нет): ");
    string ans = Console.ReadLine();
    switch (ans)
    {
        case "да":
            break;
        default:
            flag = false;
            break;
    }
}
Console.WriteLine("Спасибо за игру!");

// Дополнительное задание ★★★
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;
int sum = 0;
int counter = 0;
while (a > 0)
{
    sum += a % 10;
    counter += 1;
    a /= 10;
}
Console.WriteLine($"Сумма цифр в числе {b}: {sum}, количество: {counter}");