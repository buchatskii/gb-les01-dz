// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if(number1 > number2)
// {
//     Console.WriteLine(number1);
// }
// else
// {
//     Console.WriteLine(number2);
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.Write("");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("");
// int number3 = Convert.ToInt32(Console.ReadLine());

// if(number1 > number2 & number1 > number3)
// {
//     Console.WriteLine(number1);
// }
// if (number2 > number1 & number2 > number3)
// {
//     Console.WriteLine(number2);
// }
// else
// {
//     Console.WriteLine(number3);
// }


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number % 2 == 0)
// {
//    Console.WriteLine("Четное");
// }
// else
// {
//     Console.WriteLine("Ошибка");
// }


// Задача 5: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int x = -number;
// if (number >= 0 )
// {
//     while (x <= number)
//     {
//         Console.WriteLine(x);
//         x = x + 1;
//     }
// }



// Задача 8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int chetnoe = 1;
// if (number > 1)
// {
//     while (chetnoe <= number)
//     {
//         while (chetnoe % 2 == 0)
//         {
//             Console.WriteLine(chetnoe);
//             chetnoe = chetnoe + 1;
//         }
//         chetnoe = chetnoe + 1;
//     }
// }
// else if (number < -1)
// {
//     while (-chetnoe >= number)
//     {
//         while (number % 2 == 0)
//         {
//             Console.WriteLine(number);
//             number = number + 1;
//         }
//         number = number + 1;
//     }
// }
// else
// Console.WriteLine("Не удовлетворительное значение, для условия задачи");




// Задача 7: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// number = number % 10;

// Console.WriteLine(number);