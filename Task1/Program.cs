// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 5
// 782 -> 8
// 918 -> 1

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

bool IsDigitCapacityRight(int intNumber, int intCapacity) // Проверка количества разрядов
{
    int intTemp = Math.Abs(intNumber);
    if (intCapacity > 0)
    {
        double dblPower = Convert.ToDouble(intCapacity);
        return (intTemp >= Math.Pow(10.0, dblPower - 1) && intTemp < Math.Pow(10.0, dblPower));
    }
    else
    {
        System.Console.WriteLine($"Разрядность при вызову функции isDigitCapacityRight указана неверно, ожидается натуральное число (1, 2, 3 ..), а указано {intCapacity}");
        return false;
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

System.Console.Clear();
int intNumber = PromptInt("Введите целое трехзначное число: ");
System.Console.WriteLine(intNumber);
if (IsDigitCapacityRight(intNumber, 3))
{
    System.Console.WriteLine($"Вторая цифра трехзначного числа {intNumber} равна {TakeLastDigit(ReduceCapacity(intNumber))}");
}
else
{
    System.Console.WriteLine("Введено не трехзначное число, попробуйте снова.");
}