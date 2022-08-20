// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int sizeArray = GetNumberFromUser("Введите длину массива: ", "Ошибка ввода!");
int[] array = GetArray(sizeArray, 100, 999);
int numberOfEvenNumbers = CountEvenNumbers(array);

Console.WriteLine($"[{String.Join(", ", array)}] -> {numberOfEvenNumbers}");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int CountEvenNumbers(int[] arr)
{
    int evenNumbers = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) evenNumbers++;
    }
    return evenNumbers;
}
