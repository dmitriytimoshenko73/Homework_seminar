/*Console.Write("Введите количество столбцов ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк ");
int columns = int.Parse(Console.ReadLine());

double [ , ] numbers = new double [rows , columns];

GetMatrix (numbers);

Print (numbers);

void GetMatrix(double [ , ] matrix)
{
    for (int i = 0; i < matrix.GetLength (0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            matrix[i, l] = new Random().Next(-99, 99) / 10.0;
        }
    }
    
}

void Print(double [ , ] matrix)
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

int i = ReadInt ("Введите индекс строки  ");
int l = ReadInt ("Введите индекс столбца  ");

if (i < numbersA.GetLength(0) && l < numbersA.GetLength(1))

{
    Console.Write(numbersA[i, l]);
}

else

{
    Console.WriteLine($"такого числа в масссиве нет");
}
int ReadInt (string message) 
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}  
*/


Console.Write("Введите количество столбцов ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк ");
int columns = int.Parse(Console.ReadLine());
int[,] numbers = new int[rows, columns];

GetArray(numbers);

Prints(numbers);

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


double [] avgNumbers = new double [numbers.GetLength(1)];
double result = 0.0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
        for (int l = 0; l < numbers.GetLength(1); l++);
        }
        result += numbers [i, l];
        {
         avgNumbers[i] = result / numbers.GetLength (0); 
        }
PrintAvg (avgNumbers);       

void PrintAvg (double [] numbers)
{
    for (int l = 0; l < numbers.Length; l++ )
    {
        Console.Write($"Среднее арифметическое элементов в каждом столбце {result}" + " ");
    }
    Console.WriteLine();
} 
