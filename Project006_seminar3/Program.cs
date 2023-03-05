// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

// Console.WriteLine ("Введите номер четверти " );
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CheckKoord2(x));


// string CheckKoord2(int x)
// {
//     string res = "Введены некорректные значения";
//     if (x ==1)
//         res = "x>0, y>0" ;
//     else if (x ==4)
//         res = "x>0, y<0" ;
//     else if (x ==3)
//         res = "x<0, y<0" ;
//     else if (x ==2)
//         res = "x<0, y>0" ;
//     return res;
// }

////////////////////////////////////////////////////////
// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.
//
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine ("Введите координату первой точки х" ); 
// int x1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine ("Введите координату первой точки y" ); 
// int y1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine ("Введите координату второй точки х" ); 
// int x2 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine ("Введите координату второй точки y" ); 
// int y2 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine(Length(x1, x2, y1, y2)); 
 
 
// double Length (int x1, int x2, int y1, int y2) 
// { 
//     return Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)); 
// } 

///////////////////////////////////////////////////////////////
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
//
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4

// Console.WriteLine ("Введите число N" ); 
// int N = Convert.ToInt32(Console.ReadLine()); 
// Square (N); 
 
// void Square (int N) 
// { 
//     Console.Write(N+" -> "); 
//     for (int i=1;i<=N;i++) 
//     Console.Write(Math.Pow(i,2)+", "); 
// }

/////////////////////////////////////////////////////////////////
