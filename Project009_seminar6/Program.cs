// ============================= Задача 39:
// Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// void FillArray(int [] array )  
// {      
//     for (int i =0; i<array.Length; i++)          
//     array[i] = new Random().Next(-100,101);  
// }   

// void PrintArray(int [] array)  
// {      
//     foreach (int el in array)      
//     {          
//         Console.Write($"{el} ");      
//     }      
//     Console.WriteLine();  
// }

// void ChangeArray(int [] array)
// {
//    // int temp;
//     for (int i =0; i<array.Length/2; i++)  
//     {
//         // temp = array[i];
//         // array[i] = array[array.Length-1-i];
//         // array[array.Length-1-i] = temp;
//         (array[i] , array[array.Length-1-i]) = (array[array.Length-1-i], array[i]);
//     }
// }


// int [] array = new int [7];
// FillArray(array);
// PrintArray(array);
// ChangeArray(array);
// PrintArray(array);

//////////////////////////////////////////////////

// ============================= Задача 40:
// Напишите программу, которая принимает на вход три числа и проверяет, может ли
// существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.WriteLine("Введите число 1"); 
// int num1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите число 2"); 
// int num2 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите число 3"); 
// int num3 = Convert.ToInt32(Console.ReadLine()); 

// bool Check ( int num1, int num2, int num3 ) 
// { 
//     bool prov = false; 
//     if (num1<num2+num3 && num2<num1+num3 && num3<num1+num2) 
//         prov = true; 
//     return prov; 
// } 

// Console.WriteLine(Check( num1, num2, num3 )); 


// ================================= Задача 42:
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.WriteLine("Введите десятичное число "); 
// int num1 = Convert.ToInt32(Console.ReadLine()); 

// string MetodPreobr ( int num1) 
// { 
//     int num2 = num1; 
//     string result = ""; 
//     while (num2>0) 
//     { 
//         result =  Convert.ToString(num2%2)+ result; 
//         num2 = num2/2; 
//     } 
//     // Console.WriteLine($" result {result}"); 
//     return result; 
// } 

// Console.WriteLine(MetodPreobr(num1));


///////////////////////////////////////////////////////

// ===================================== Задача 44:
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.Write("Введите число N = ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];



// void FillArray(int[] array)
// {
//     array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < array.Length; i++)
//         array[i] = array[i - 1] + array[i - 2];
// }


// FillArray(array);
// foreach (int i in array)
//     Console.Write(" " + i);
//     Console.WriteLine();

// =========================================== Задача НЕГАФИБОНАЧЧИ.
// Задайте число. Составьте список чисел НегаФибоначчи, в том числе для отрицательных индексов.
// *Пример:*
// - для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

// Console.Write("Введите число k = ");
// int k = Convert.ToInt32(Console.ReadLine());
// int len = k + k - 1;
// int[] array = new int[len];
// FillArray(array, k, len);
// PrintArray(array);


// void FillArray(int[] array, int k, int len)
// {
//     array[len / 2] = 0;
//     array[len / 2 + 1] = 1;
//     array[len / 2 - 1] = 1;
//     for (int i = 2; i < k; i++)
//     {
//         array[len / 2 + i] = array[len / 2 + i - 1] + array[len / 2 + i - 2];
//         array[len / 2 - i] = array[len / 2 - i + 2] - array[len / 2 - i + 1];
//     }
// }

// void PrintArray(int[] array)
// {
//     foreach (var item in array)
//         Console.Write($"{item}, ");
//     Console.WriteLine();
// }