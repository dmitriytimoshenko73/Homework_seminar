/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine ("Введите любое целое трехзначное число  ");
int number = int.Parse(Console.ReadLine());
int numberRes=0;
if (number >= 100 && number < 1000)
{
    numberRes = number%100;

    numberRes = numberRes/10;

System.Console.WriteLine(numberRes);
}
else
{
    System.Console.WriteLine("Это не трехзначное число");
}

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine ("Введите любое целое  число  ");
int numberA= int.Parse(Console.ReadLine());
int i=100;

while (i<=numberA)
{
    i*=10;
}
if (numberA<100)

{

     System.Console.WriteLine("Третьей цифры нет");
}     

else

{
    numberRes = numberA%(i/100);

     numberRes = numberRes/(i/1000);

     System.Console.WriteLine(numberRes);
}

/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine ("Введите цифру от 1 до 7, обозначающую день недели  ");
int numberB= int.Parse(Console.ReadLine());
if (numberB == 6 || numberB == 7)
{
    Console.WriteLine ("Выходной день  ");
}

else if (numberB > 7)

{

    Console.WriteLine ("Цифра введена не корректно  ");
    
}

else

{
    Console.WriteLine ("Рабочий день  ");

}


