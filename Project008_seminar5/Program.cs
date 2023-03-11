// //======================== Задача 31:
// // Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// // Найдите сумму отрицательных и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// // сумма отрицательных равна -20.


// void FillArray(int [] array )
// {
//     for (int i =0; i<array.Length; i++)
//         array[i] = new Random().Next(-9,10);
// }

// void PrintArray(int [] array)
// {
//     foreach (int el in array)
//     {
//         Console.Write($"{el} ");
//     }
//     Console.WriteLine();
// }

// void Summa(int [] array)
// {
//     int sump=0;
//     int sumn=0;
//     for (int i =0; i<array.Length; i++)
//         if (array[i]>0) sump+=array[i];
//         else sumn+=array[i];
//     Console.WriteLine($"Сумма положительных элементов равна {sump}");
//     Console.WriteLine($"Сумма отрицательных элементов равна {sumn}");
// }

// int[] Summa2(int [] array)
// {
//     int sump=0;
//     int sumn=0;
//     for (int i =0; i<array.Length; i++)
//         if (array[i]>0) sump+=array[i];
//         else sumn+=array[i];

//     int[] results = {sump,sumn};
//     return results;
// }

// int [] array  = new int [12];
// FillArray(array);
// PrintArray(array);
// Summa(array);
// int [] rez = Summa2(array);
// PrintArray(Summa2(array));
// Console.WriteLine($"Сумма положительных элементов равна {rez[0]}");
// Console.WriteLine($"Сумма отрицательных элементов равна {rez[1]}");


/////////////////////////////////////////////////////////

//========================= Задача 32:
// Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// void FillArray(int [] array ) 
// {     
//     for (int i =0; i<array.Length; i++)         
//     array[i] = new Random().Next(-9,10); 
// }  
// void PrintArray(int [] array) 
// {     
//     foreach (int el in array)     
//     {         
//         Console.Write($"{el} ");     
//     }     
//     Console.WriteLine(); 
// } 
// void Negativ(int [] array)
// {
//     for(int i=0;i<array.Length;i++)
//     {
//         array[i]=array[i]*(-1);
//         Console.Write($"{array[i]} "); 
//     }
// }

// int [] array  = new int [4]; 
// FillArray(array);
// PrintArray(array); 
// Negativ(array);

////////////////////////////////////////////////////

//================================ Задача 33:
// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-10, 10);
//     }
// }

// void PrintArray(int[] array)
// {
//     foreach (int el in array)
//     {
//         Console.Write($"{el} ");
//     }
//     Console.WriteLine();
// }

// bool Proverka(int[] array, int arg)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (Math.Abs(array[i]) == Math.Abs(arg))
//         {
//             Index(array[i], arg);
//             return true;
//         }
//     }
//     return false;
// }
// ==========================================
// int Index(int num)
// {
//     int count = 0;
//     while ((num % 1) > 0)
//     {
//         num = (num * 10);
//         Console.WriteLine(num);
//     }
//     while (num > 1)
//     {
//         num = (num / 10);
//         count += 1;
//     }
//     return count;
// }
// ===========================================?
// Console.Write("Введите число ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[5];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine(Proverka(array, N));

/////////////////////////////////////////////

// ======================== Задача 35:
// Задайте одномерный массив из 12 случайных чисел от -100 до 100. Найдите 
// количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5,
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100, 101);
// }
// void PrintArray(int[] array)
// {
//     foreach (int el in array)
//         Console.Write($"{el} ");
//     Console.WriteLine();
// }
// int Count(int[] array)
// {
//     int count = 0;
//     foreach (int el in array)
//         if (el >= 10 && el < 100) count++;
//     return count;
// }

// int[] array = new int[12];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine($"Количество цифр от 10 до 99 {Count(array)}");

/////////////////////////////////////////////////
// =============================== Задача 37:
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый
//  и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 10);
//     }
// }

// void PrintArray(int[] array)
// {
//     foreach (int el in array)
//     {
//         Console.Write($"{el} ");
//     }
//     Console.WriteLine();
// }

// int[] Sum(int[] array)
// {
//     int[] res = new int[array.Length / 2 + array.Length % 2];
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         res[i] = array[i] * array[array.Length - 1 - i];
//     }
//     if (array.Length % 2 != 0)
//     {
//         res[array.Length / 2] = array[array.Length / 2];
//     }

//     return res;

// }


// Console.Write("Введите количество элементов массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];

// FillArray(array);
// PrintArray(array);
// int[] result = Sum(array);
// PrintArray(result);

// =====================

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 11);
// }

// void PrintArray(int[] array)
// {
//     foreach (int el in array)
//         Console.Write($"{el} ");
//     Console.WriteLine();
// }

// void CreateSumArray(int[] array, int[] sumArray)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//         sumArray[i] = (array[i] * array[^(i + 1)]);
//     if ((array.Length % 2) != 0)
//         sumArray[^1] = array[array.Length / 2];
// }

// Console.Write("Введите количество чисел массива > ");
// int[] array = new int[Convert.ToInt32(Console.ReadLine())];
// FillArray(array);
// PrintArray(array);
// int[] sumArray = new int[array.Length / 2 + array.Length % 2];
// CreateSumArray(array, sumArray);
// PrintArray(sumArray);
// =========================


