// int sum = 0;
// for (int i = 10; i >= 1; i--)
// {
//     sum += i;
// }
// Console.WriteLine($"Сумма: {sum}");
// for (int i = 2; i <= 50; i += 2)
// {
//     Console.WriteLine(i);
// }
// int count = 0;
// for (int i = 1; i <= 20; i++)
// {
//     if (i % 5 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Чисел, кратных 5: {count}");
// int number = Convert.ToInt32(Console.ReadLine());
// int poloz = 0;
// int otric = 0;
// while (number != 0)
// {
//     if (number > 0)
//     {
//         poloz++;
//     }
//     else if (number < 0)
//     {
//         otric++;
//     }
//     number = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Положительных чисел: {poloz}");
// Console.WriteLine($"Отрицательных чисел: {otric}");
// string password;
// int c = 0;
// do
// {
//     Console.Write("Введите пароль: ");
//     password = Console.ReadLine();
//     if (c <= 3)
//     {
//         c += 1;
//         if (password == "qwerty")
//         {
//             Console.WriteLine("Доступ разрешен");
//             break;
//         }
//     }
//     else
//     {
//         Console.WriteLine("Доступ заблокирован");
//         break;
//     }
// }
// while (c <= 3);
// Console.Write("Введите число 0-9: ");
// int a = int.Parse(Console.ReadLine());
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{a} x {i} = {a * i}");
// }
// for (int i = 1; i <= 30; i++)
// {
//     if (i % 3 != 0)
//     {
//         Console.WriteLine(i);
//     }
//     else
//     {
//         continue;
//     }
// }
// int secret = 42;
// int ans;
// for (int i = 1; i <= 5; i++)
// {
//     Console.Write("Введите число: ");
//     ans = int.Parse(Console.ReadLine());
//     if (ans == secret)
//     {
//         Console.WriteLine($"Победа! Попыток: {i}");
//         break;
//     }
//     else
//     {
//         if (ans < secret && i != 5)
//         {
//             Console.WriteLine("Больше");
//             continue;
//         }
//         else if (ans > secret && i != 5)
//         {
//             Console.WriteLine("Меньше");
//             continue;
//         }
//         else
//         {
//             Console.WriteLine("Вы проиграли, число было 42");
//         }
//     }
// }
using System.Diagnostics.CodeAnalysis;

Console.Write("Введите целое число: ");
int a = int.Parse(Console.ReadLine());
int s = 0;
while (a > 0)
{
    s += a % 10;
    a /= 10;
}
Console.WriteLine(s);