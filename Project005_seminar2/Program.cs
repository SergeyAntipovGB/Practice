// Напишите программу, которая выводит случайное число из отрезка 
//[10, 99] и показывает 
// наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int num = new Random().Next(10,100);
// Console.WriteLine($"Было сгенерировано число {num}");
// int x1 = num / 10;
// int x2 = num % 10;
// if (x1>x2) 
//     Console.WriteLine($"Наибольшая цифра это {x1}");
// else if (x1==x2)
//     Console.WriteLine("Все цифры этого числа равны");
// else    
//     Console.WriteLine($"Наибольшая цифра это {x2}");



////////////////////////////////////////////////////
// Выведем в строку все цифры от 1 до сгенерированного

// int num = new Random().Next(2,201);
// Console.WriteLine(num);
// for (int i=1; i<=num; i++)
//     Console.Write(i + " ");
// Console.WriteLine();


//////////////////////////////////////////////////////
//Напишите программу, которая выводит случайное трехзначное число и удаляет 
//                   вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int first, third;
// int random = new Random().Next(100, 1000);
// Console.WriteLine("случайное число " + random);
// first = random / 100;
// third = random % 10;
// Console.WriteLine($"{first}{third}");


//////////////////////////////////////////////////////
//Напишите программу, которая выводит случайное число c любым количеством разрядов и удаляет 
//                   вторую цифру этого числа.

// int temp;
// string newnum = "";
// int random = new Random().Next(1, 1000000000);
// Console.WriteLine("случайное число " + random);
// if (random < 10) Console.WriteLine("слишком маленькое число");
// else
// {
//     while (random > 99)
//     {
//         temp = random % 10;
//         random = random / 10;
//         newnum = Convert.ToString(temp) + newnum;
//     }
//     random = random / 10;
//     newnum = Convert.ToString(random) + newnum;
//     Console.WriteLine(newnum);
// }


///////////////////////////////////////////////////////////
// Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.Write("Введите число 1 ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2 ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if ((num1 % num2) == 0)
//     Console.WriteLine("кратно");
// else
// {
//     Console.WriteLine("не кратно, остаток " + (num1 % num2));
// }

//////////////////////////////////////////////
// Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.Write("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (((num%7)==0) && ((num%21)==0))
// Console.WriteLine("кратно");
// else Console.WriteLine("не кратно");


///////////////////////////////////////////////
// Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.Write("Введите число 1 ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2 ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if ((num1 == num2 * num2) || (num2 == num1 * num1))
//     Console.WriteLine("да");
// else Console.WriteLine("нет");


