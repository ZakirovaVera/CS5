// Задача 36: Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int sizeArray = GetNumberFromUser("Введите длину массива: ", "Ошибка ввода!");
int startArray = GetNumberFromUser("Введите минимальное число массива: ", "Ошибка ввода!");
int endArray = GetNumberFromUser("Введите максимальное число массива: ", "Ошибка ввода!");
int[] array = GetArray(sizeArray, startArray, endArray);
int sumNumOfOddPositions = GetSumNumberOddPossition(array);

Console.WriteLine($"[{String.Join(", ", array)}] -> {sumNumOfOddPositions}");

int GetNumberFromUser(string message, string errorMessage)
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

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetSumNumberOddPossition(int[] arr)
{
    int sumOddPossition = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            sumOddPossition += arr[i];
        }
    }
    return sumOddPossition;
}
