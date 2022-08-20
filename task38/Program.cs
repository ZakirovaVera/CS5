﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int sizeArray = GetSizeArrayFromUser("Введите длину массива: ", "Ошибка ввода!");
double startArray = GetNumberFromUser("Введите минимальное число массива: ", "Ошибка ввода!");
double endArray = GetNumberFromUser("Введите максимальное число массива: ", "Ошибка ввода!");
double[] array = GetArray(sizeArray, startArray, endArray);
double diffBetweenMinMax = GetDiffBetweenMinMax(array);

Console.WriteLine($"[{String.Join(", ", array)}] -> {diffBetweenMinMax}");

int GetSizeArrayFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

double GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(message);
        bool isCorrect = double.TryParse(Console.ReadLine(), out double userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().NextDouble() * (maxValue + 1 - minValue) + minValue;
    }
    return res;
}

double GetDiffBetweenMinMax(double[] arr)
{
    int i = 0;
    double minNum = arr[i]; ;
    double maxNum = arr[i];
    double diffMinMax = 0;
    foreach (double el in arr)
    {
        if (el > maxNum) maxNum = el;
        if (el < minNum) minNum = el;
    }
    return diffMinMax = maxNum - minNum;
}
