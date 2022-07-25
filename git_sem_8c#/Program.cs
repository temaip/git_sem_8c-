
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//  Console.Clear();

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
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
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальный элемент массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальный элемент массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] array = GetArray(rows, columns, min, max);
// PrintArray(array);
// Console.WriteLine("----------------------- ");

// int RowNumbers (int [,] array)
// {
//     int row = 0;
//     int minsum = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minsum = minsum + array [0,i];
//     }
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i,j];
//         }
//         if (minsum > sum)
//         {
//             minsum = sum;
//             row = i;
//         }
//     }
//     return row;
// }
// Console.WriteLine($"Номер строки с нименьшей суммой {RowNumbers(array)}");

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
 
// В данной задаче не понимаю в чем проблема, почему не выводит на консоль, уже посмотрел ваше решение, все равно....
 
//  Console.Clear();

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }
// int[,] GetArray1(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
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
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void softArray (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int t = j+1; t < array.GetLength(1); t++)
//             {
//                 if (array[i,t] > array [i,j])
//                 {
//                     int temp = array [i,j];
//                     array[i,j] = array [i,t];
//                     array [i,t] = temp;
//                 }
//             }
//         }
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальный элемент массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальный элемент массива: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] array = GetArray(rows, columns, min, max);
// int[,] array1 = GetArray1(rows, columns, min, max);
// PrintArray(array);
// Console.WriteLine("----------------------- ");
// softArray(array1);
// PrintArray(array1);


// Задача 62. Заполните спирально массив 4 на 4.

 Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [m,n];


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int s = 1;
  for (int y = 0; y < n; y++) {
            array[0,y] = s;
            s++;
        }
        for (int x = 1; x < m; x++) {
            array[x,n - 1] = s;
            s++;
        }
        for (int y = n - 2; y >= 0; y--) {
            array[m - 1,y] = s;
            s++;
        }
        for (int x = m - 2; x > 0; x--) {
            array[x,0] = s;
            s++;
        }

int c = 1;
int d = 1;
if (m == n)
{
    

while (s < m * n) 
{
    
 
    
while (array[c,d + 1] == 0) 
{
array[c,d] = s;
s++;
d++;
}
 
while (array[c + 1,d] == 0) 
{
array[c,d] = s;
s++;
c++;
}
 
            
while (array[c,d - 1] == 0) 
{
array[c,d] = s;
s++;
d--;
}
 
while (array[c - 1,d] == 0) 
{
array[c,d] = s;
s++;
c--;
}
}
 
   
   
for (int x = 0; x < m; x++) 
{
for (int y = 0; y < n; y++) 
{
if (array[x,y] == 0) 
{
array[x,y] = s;
                
                
}
}
}
PrintArray(array);
}
else 
Console.Write("Количество стро, должно совпадать с количеством столбцов, повторите команду ");
