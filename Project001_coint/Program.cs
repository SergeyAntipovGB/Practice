int x, x1, y, temp;
string? coint = "y";
while (coint == "y")
{
    x = new Random().Next(5, 51);
    Console.WriteLine($"случайное число x = {x}");
    x1 = x;
    //temp = x;
    //y = x++;
    //x = temp;
    Console.WriteLine($"результат операции х++ возвращает {x++}");
    Console.WriteLine($"значеие х при этом становится {x}");
    Console.WriteLine($"изначальное число {x1}");
    //temp = x;
    //y = ++x;
    x = x1;
    //x = temp;
    Console.WriteLine($"результат операции ++х возвращает {++x}");
    Console.WriteLine($"значеие х при этом становится {x}");
    Console.WriteLine($"изначальное число {x1}");
    //temp = x;
    //y = x--;
    x = x1;
    //x = temp;
    Console.WriteLine($"результат операции х-- возвращает {x--}");
    Console.WriteLine($"значеие х при этом становится {x}");
    Console.WriteLine($"изначальное число {x1}");
    //temp = x;
    //y = --x;
    x = x1;
    //x = temp;
    Console.WriteLine($"результат операции --x возвращает {--x}");
    Console.WriteLine($"значеие х при этом становится {x}");
    Console.WriteLine($"изначальное число {x1}");
    coint = Console.ReadLine();
}