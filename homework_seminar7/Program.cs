Console.Write("Введите количество столбцов ");
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

