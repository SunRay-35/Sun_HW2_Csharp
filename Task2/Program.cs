// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int RandomInt (int intCapacity) // Генерация случайного числа с заданой разрядностью
{
    if (intCapacity <= 0)
    {
        System.Console.WriteLine("Разрядность при вызове функции RandomInt указана неверно, ожидается натуральное число (1, 2, 3 ..). Сгенерировано число с разрадностью 1.");
        intCapacity = 1;
    }
    double dblPower = Convert.ToDouble(intCapacity);
    return new Random().Next(Convert.ToInt16(Math.Pow(10.0, dblPower - 1)), Convert.ToInt16(Math.Pow(10.0, dblPower)));
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
int intNumber = RandomInt(3);
System.Console.WriteLine($"Число, состоящее из первой и третьей цифры трехзначного числа {intNumber}, равно {TakeLastDigit(ReduceCapacity(ReduceCapacity(intNumber)))}{TakeLastDigit(intNumber)}");