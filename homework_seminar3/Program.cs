/*Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.*/

Console.WriteLine ("Введите любое целое пятизначное число  ");
int number = int.Parse(Console.ReadLine());

if ((number / 10000 == number % 10) && (number % 100 / 10 == number / 1000 % 10))
{
    System.Console.WriteLine("Это палиндром");
}
else
{
    System.Console.WriteLine("Это не палиндром");
}


/* Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.*/

Console.Write ("Enter number X1  ");
double numX1 = double.Parse(Console.ReadLine());

Console.Write ("Enter number Y1  ");
double numY1 = double.Parse(Console.ReadLine());

Console.Write ("Enter number Z1  ");
double numZ1 = double.Parse(Console.ReadLine());

Console.Write ("Enter number X2  ");
double numX2 = double.Parse(Console.ReadLine());

Console.Write ("Enter number Y2  ");
double numY2 = double.Parse(Console.ReadLine());

Console.Write ("Enter number Z2  ");
double numZ2 = double.Parse(Console.ReadLine());

double numSQRT= Math.Pow((numX1 - numX2), 2)+Math.Pow((numY1 - numY2), 2)+Math.Pow((numZ1 - numZ2), 2);
double result = Math.Sqrt(numSQRT);
{  
    Console.WriteLine(result.ToString("c2"));

}


/*Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.*/

Console.WriteLine ("Enter number  ");
int num = int.Parse(Console.ReadLine());

int i = 1;

while (i <= num)
{
    Console.Write (i*i*i +" ");
    i++;
}

/* Вариант 2*/

Console.WriteLine ("Enter number  ");
double num = double.Parse(Console.ReadLine());

double i = 1;

while (i <= num)
{

    double result = Math.Pow (i, 3);
    Console.Write (result +" ");
    i++;
}
