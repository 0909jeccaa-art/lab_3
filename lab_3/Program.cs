using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введiть цiле число для перевiрки на число Армстронга:");
        // Отримання значення з клавіатури
        int originalNumber = int.Parse(Console.ReadLine());

        int number = originalNumber;
        int sum = 0;

        // Підрахунок кількості цифр у числі
        int digitsCount = originalNumber.ToString().Length;

        // Цикл для обчислення суми цифр у степені digitsCount
        while (number > 0)
        {
            int digit = number % 10;
            sum += (int)Math.Pow(digit, digitsCount);
            number /= 10;
        }

        // Умовний оператор для перевірки результату
        if (sum == originalNumber)
        {
            Console.WriteLine($"{originalNumber} є числом Армстронга.");
        }
        else
        {
            Console.WriteLine($"{originalNumber} не є числом Армстронга.");
        }
    }
}