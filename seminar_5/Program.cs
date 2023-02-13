//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int [] Array  (int size, int minValue, int maxValue)
{
    int [] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] Massiv = Array  (10, 100, 999);

Console.WriteLine(String.Join(" ", Massiv));

int EventNumbers(int[] Massiv)

{
int count = 0;
for (int i = 0; i < Massiv.Length; i++)
{
    if (Massiv[i] % 2 == 0)
    count++;
}
    return count;
}
Console.WriteLine($"количество чётных чисел в массиве -> {EventNumbers (Massiv)} ");


/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/


int[] MassivA = Array  (9, 0, 99);


Console.WriteLine(String.Join(" ", MassivA));

int SumOddPosition (int[] MassivA)
{
int sum = 0;

for (int i = 0; i < MassivA.Length; i++)
{
    if (i % 2 != 0)
    sum += MassivA[i];
}
    return sum; 
}

Console.WriteLine($"сумма элементов, стоящих на нечетных позициях -> {SumOddPosition(MassivA)}");



/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
 и минимальным элементами массива.
[3 7 22 2 78] -> 76*/


Console.WriteLine("Введите размер массива  ");
int size = int.Parse(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(-100,100)) / 10;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}


