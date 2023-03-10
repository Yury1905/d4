// Напишите цикл, который 
// принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// int sep (int n1,int n2)

// {
//     int s = 1;
//     for (int i=0; i< n2 ;i++)
//         {
//             s= s * n1;
//         }
//     return s;

// }

// Console.WriteLine("Введите число 1");
// int number1 =int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число 2");
// int number2=int.Parse(Console.ReadLine());

// Console.WriteLine($"число {number1} в степени {number2} равно {sep (number1,number2)}");

//_______________________________________________________________________________________________________


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// void FA (int[]array)
// {
//     int length=array.Length;
//     int index=0;
//     for (index=0;index<length;index++)
//         {  
//             array[index]=new Random().Next(0,10);
//             Console.Write(array[index]+ " ");
//         }
// }
// int [] ur=new int[8];
// FA (ur);