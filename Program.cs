// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());
// double GetPow(int num1, int num2)
//     {
//         double pow = Math.Pow(num1, num2);
//         return pow;
//     }
// Console.WriteLine(GetPow(a, b));


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int GetSum(int a)
//     {
//         int count = Convert.ToString(a).Length, sum = 0, temp = 0;
        
//         while (count != 0)
//             {
//                 temp = a % 10;
//                 a /= 10;
//                 sum += temp;
//                 count--; 
//             }             
//         return sum;
//     }
// Console.WriteLine(GetSum(num));


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int [] arr = new int[8];
// for (int i = 0; i < 8; i++)
//     {
//         Console.WriteLine($"Введите {i+1} число для добавления в массив");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
// Console.Write("Ваш массив: [");
// Console.Write(String.Join(", ", arr));
// Console.WriteLine("]");