﻿//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
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

int count = 0;

for (int i = 0; i < Massiv.Length; i++)
{
    if (Massiv[i] % 2 == 0)
    count++;
}

Console.WriteLine($"количество чётных чисел в массиве -> {count} ");
