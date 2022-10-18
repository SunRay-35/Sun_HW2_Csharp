// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

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

bool IsDayIsWeekend(int intNumberOfDay)
{
    if (intNumberOfDay < 1 || intNumberOfDay >7)
    {
        System.Console.Write("Введено некорректное значение дня недели.");
        return false;
    }
    else if (intNumberOfDay < 6)
    {
        System.Console.WriteLine("Нет, это рабочий день.");
        return false;
    }
    else
    {
        System.Console.WriteLine("Да! Это выходной!");
        return true;
    }
}

System.Console.Clear();
int intNumber = PromptInt("Введите порядковый номер дня недели (где 1 - понедельник, а 7 - воскресенье): ");
    if (IsDayIsWeekend(intNumber))
    {
       // Просто согласимся с ответом, а при необходимости можем обработать результат
    }
    else
    {
        // Просто согласимся с ответом, а при необходимости можем обработать результат
    }