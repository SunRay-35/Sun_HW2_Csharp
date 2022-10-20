// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

int PromptInt(string strDescription) // Ввод целого числа
{
    try
    {
        System.Console.Write(strDescription);
        int intTemp = int.Parse(System.Console.ReadLine());
        return intTemp;
    }
    catch
    {
        System.Console.WriteLine("Введено некорректное значение, попробуйте снова.");
        int intException = PromptInt(strDescription);
        return intException;
    }
}

int TakeLastDigit(int intNumber) // Возвращает остаток деления целого числа на 10
{
    return Math.Abs((intNumber % 10));
}

int ReduceCapacity(int intNumber) // Уменьшает разрядность целого числа на 1
{
    return (intNumber / 10);
}

int WhatDigitCapacity(int intNumber) // Определение количества разрядов числа
{
    if (intNumber == 0)
    {
        return 0;
    }
    else
    {
        intNumber = Math.Abs(intNumber);
        int count = 0;
        while (intNumber > 0)
        {
            intNumber = ReduceCapacity(intNumber);
            count++;
        }
        return count;
    }
}

System.Console.Clear();
int intNumber = PromptInt("Введите целое число: ");
if (WhatDigitCapacity(intNumber) > 2)
{
    int intTemp = intNumber;
    while (WhatDigitCapacity(intTemp) > 2)
    {
        intTemp = ReduceCapacity(intTemp);
    }
    System.Console.WriteLine($"Вторая цифра в числе {intNumber} равна {TakeLastDigit(intTemp)}");
}
else
{
    System.Console.WriteLine("В введеном числе третьей цифры нет.");
}