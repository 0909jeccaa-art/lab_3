using System;

class Program
{
    static void Main()
    {
        // Ініціалізація одновимірного масиву при створенні
        int[] array = { -5, 0, 10, -3, 8, 0, 12, -1, 4 };

        int positiveCount = 0; // Додатні
        int negativeCount = 0; // Від'ємні
        int zeroCount = 0;     // Нульові

        // Перебір елементів масиву
        foreach (int element in array)
        {
            if (element > 0)
            {
                positiveCount++;
            }
            else if (element < 0)
            {
                negativeCount++;
            }
            else
            {
                zeroCount++;
            }
        }

        // Виведення результатів у консоль
        Console.WriteLine($"Елементи масиву: {string.Join(", ", array)}");
        Console.WriteLine($"Кiлькiсть додатних елементiв: {positiveCount}");
        Console.WriteLine($"Кiлькiсть вiд'ємних елементiв: {negativeCount}");
        Console.WriteLine($"Кiлькiсть нульових елементiв: {zeroCount}");
    }
}