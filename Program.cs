// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// Console.Write("Введите количество строк первой матрицы: ");
// int rows1 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов первой матрицы: ");
// int columns1 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество строк второй матрицы: ");
// int rows2 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов второй матрицы: ");
// int columns2 = int.Parse(Console.ReadLine()!);

// while(columns1 != rows2)
//     {
//         Console.WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
//         Console.Write("Введите количество строк первой матрицы: ");
//         rows1 = int.Parse(Console.ReadLine()!);
//         Console.Write("Введите количество столбцов первой матрицы: ");
//         columns1 = int.Parse(Console.ReadLine()!);
//         Console.Write("Введите количество строк второй матрицы: ");
//         rows2 = int.Parse(Console.ReadLine()!);
//         Console.Write("Введите количество столбцов второй матрицы: ");
//         columns2 = int.Parse(Console.ReadLine()!);
//     }

// int[,] array1 = GetArray(rows1, columns1, 0, 10);
// PrintArray(array1);

// Console.WriteLine();

// int[,] array2 = GetArray(rows2, columns2, 0, 10);
// PrintArray(array2);

// Console.WriteLine();

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] resultArray = new int[rows1, columns2];

// MultiplyArray (array1, array2, resultArray);
// Console.WriteLine($"Проведение первой и второй матрицы:");
// PrintArray(resultArray);

// void MultiplyArray(int[,] array1, int[,] array2, int[,] resultArray)
// {
//   for (int i = 0; i < resultArray.GetLength (0); i++)
//   {
//     for (int j = 0; j < resultArray.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < array1.GetLength(1); k++)
//       {
//         sum += array1[i, k] * array2[k, j];
//       }
//       resultArray[i,j] = sum;
//     }
//   }
// }


// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// Console.WriteLine();

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine($"Отсортированный массив: ");
// SortingArray(array);
// PrintArray(array);

// void SortingArray (int [,] Arr )
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if(array[i, k] < array [i, k + 1])
//         {
//           int temp = array [i, k + 1];
//           array [i, k + 1] = array [i, k];
//           array [i, k] = temp;
//         }
//       }
//     }
//   }
// }

