/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.WriteLine("Введите натуральное число больше 1:");
int number = int.Parse(Console.ReadLine());

///Метод вывода натуральных чисел от N до 1:
void NumberCounter(int number)
{
    if (number < 0) 
    {
        Console.Write($"{number} не натуральное число"); 
        return;
    }
    else if (number == 0) return;
    Console.Write(number + " ");
    NumberCounter(number - 1);
}

NumberCounter(number);


/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
 элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
Console.WriteLine();
Console.WriteLine();
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSumm(m, n, temp=0);

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}


/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
Console.WriteLine();
Console.WriteLine();
int k = InputNumbers("Введите m: ");
int l = InputNumbers("Введите n: ");

///Метод вычисления функции Аккермана:
int AckermannFunction (int k, int l)
{
    if (k == 0) return l + 1;
    if (k != 0 && l == 0) return AckermannFunction(k - 1, 1);
    if (k > 0 && l > 0) return AckermannFunction(k - 1, AckermannFunction (k,l - 1));
return AckermannFunction(k, l);
}

Console.WriteLine($"Функция Аккермана для чисел A({k},{l}) = {AckermannFunction(k, l)}");
