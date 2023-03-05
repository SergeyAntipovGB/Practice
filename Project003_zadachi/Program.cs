// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



// Console.Write("введите два целых числа quad=");
// int quad = Convert.ToInt32(Console.ReadLine());
// Console.Write("и a=");
// int a = Convert.ToInt32(Console.ReadLine());

// int res = a * a;
// if (quad == res)
//     Console.WriteLine("quad является квадратом а");
// else
//     Console.WriteLine("quad не является квадратом а");




// Console.Write("введите порядковый номер дня недели: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day == 1)
//     Console.WriteLine("сегодня понедельник");
// else
//     if (day == 2)
//         Console.WriteLine("сегодня вторник");
//     else
//         if (day == 3)
//             Console.WriteLine("сегодня среда");
//         else
//             if (day == 4)
//                 Console.WriteLine("сегодня четверг");
//             else
//                 if (day == 5)
//                     Console.WriteLine("сегодня пятница");
//                 else
//                     if (day == 6)
//                         Console.WriteLine("сегодня суббота");
//                     else
//                         if (day == 7)
//                             Console.WriteLine("сегодня воскресенье");
//                         else Console.WriteLine("ввели неправильное число");


try
{
    Console.Write("введите порядковый номер дня недели: ");
    string day = Console.ReadLine();
    switch (day)
    {
        case "1":
            Console.WriteLine("сегодня понедельник");
            break;
        case "2":
            Console.WriteLine("сегодня вторник");
            break;
        case "3":
            Console.WriteLine("сегодня среда");
            break;
        case "4":
            Console.WriteLine("сегодня четверг");
            break;
        case "5":
            Console.WriteLine("сегодня пятница");
            break;
        case "6":
            Console.WriteLine("сегодня суббота");
            break;
        case "7":
            Console.WriteLine("сегодня воскресенье");
            break;
        default:
            Console.WriteLine("ввели неправильное число");
            break;
    }
}
catch (System.FormatException)
{
    Console.WriteLine("Введено некорректное число");
}