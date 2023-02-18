/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

Console.Write("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());

double[,] numbers = new double[rows, columns];

GetMatrix(numbers);

Print(numbers);

void GetMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            matrix[i, l] = new Random().Next(-99, 99) / 10.0;
        }
    }

}

void Print(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write(matrix[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}

Console.WriteLine();
int[,] numbersA = new int[rows, columns];

GetArray(numbersA);

Prints(numbersA);

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            array[i, l] = new Random().Next(1, 20);
        }
    }

}

void Prints(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            System.Console.Write(array[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

int i = ReadInt("Введите индекс строки  ");
int l = ReadInt("Введите индекс столбца  ");

if (i < numbersA.GetLength(0) && l < numbersA.GetLength(1))

{
    Console.Write($"число {numbersA[i, l]}");
}

else

{
    Console.WriteLine($"такого числа в масссиве нет");
}
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

Console.WriteLine();

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
 в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 
*/


AvgResult(numbersA);

void AvgResult(int[,] numbersA)

{

    for (int l = 0; l < numbersA.GetLength(1); l++)

    {
        double result = 0;
        for (int i = 0; i < numbersA.GetLength(0); i++)

        {
            result += numbersA[i, l];
        }
        Console.WriteLine();
        Console.Write($"Среднее арифметическое ");
        Console.WriteLine($"{result / numbersA.GetLength(0)}" + " ");
    }
    Console.WriteLine();
}


/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
Console.WriteLine();
int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int c = 0;
int d = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[c, d] = temp;
  temp++;
  if (c <= d + 1 && c + d < sqareMatrix.GetLength(1) - 1)
    d++;
  else if (c < d && c + d >= sqareMatrix.GetLength(0) - 1)
    c++;
  else if (c >= d && c + d > sqareMatrix.GetLength(1) - 1)
    d--;
  else
    c--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
  



