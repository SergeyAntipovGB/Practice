// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int Summa(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//         sum += i; // sum = sum + i;
//     return sum;
// }


// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма всех чисел от 1 до {num} равна {Summa(num)}");

///////////////////////////////////////////

// Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Index(decimal num)
{
    int count = 0;
    while ((num % 1) > 0)
    {
        num = (num * 10);
        Console.WriteLine(num);
    }
    while (num > 1)
    {
        num = (num / 10);
        count += 1;
    }
    return count;
}

Console.WriteLine("Введите число");
decimal num = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine(Index(num));



//=================================
//=================================

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

//++++++
// int Factorial(int n)
// {
//     int rst = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         rst = rst * i;
//     }
//     return rst;
// }

// int FactorialRec(int n)
// {
//     if (n == 1) return 1;
//     return n * (FactorialRec(n - 1)); // -----Рекурсивный метод------
// }

// Console.WriteLine(FactorialRec(6));
// Console.WriteLine(Factorial(6));

//+++++++


// int Proinzvedenie(int num)
// {
//     int pro=1;
//     for (int i =1; i<=num;i++)
//         pro*=i;
//     return pro;
// }


// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Произведение всех чисел от 1 до {num} равна {Proinzvedenie(num)}");

//////////////////////////////////////////////////////
//====================== Задача 30:
// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] Mas()
// {
//     int[] array = new int[8];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//         Console.Write($"{array[i]}, ");
//     }
//     Console.WriteLine();
//     return array;
// }


// int[] array = Mas();



///////////////////////////////////////////////////////

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. 
// [1,0,1,1,0,1,0,0] 
// true если единиц больше нулей иначе false 

// int[] CreateArr(){ 
//   int[] tempArr = new int[8]; 
//   for (int i = 0; i < tempArr.Length; i++){ 
//     int randomNum = new Random().Next(0, 2); 
//     tempArr[i] = randomNum; 
//   } 
//   return tempArr; 
// } 

// void PrintArr(int[] tempArr){ 
//   foreach (int i in tempArr){ 
//       Console.Write(i + " "); 
//   } 
// } 

// bool NumCheck(int[] tempArr){ 
//   int countOne = 0; 
//   int countZero = 0; 

//   for (int i = 0; i < tempArr.Length; i++){ 
//     if(tempArr[i] == 0) countZero++; 
//     else countOne++; 
//   } 
//   return countOne > countZero ? true: false; 
// } 

// int[] arr = CreateArr(); 
// PrintArr(arr); 
// Console.WriteLine(); 
// Console.WriteLine(NumCheck(arr));

