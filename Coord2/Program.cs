// Задача 2: Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

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

bool ValidateQuarter (int Quarter)
{
    if (Quarter > 0 && Quarter < 5)
    {
        return true;
    }
    return false;
}

(int, int) FindCoords(int Quarter) // функция поиска шаблона координат
{
    if (Quarter == 1) return (1, 1);
    if (Quarter == 2) return (-1, 1);
    if (Quarter == 3) return (-1, -1);
    return (1, -1);
}

int Quarter = PromptInt ("Введите номер четверти: ");
if (ValidateQuarter(Quarter))
{
    (int x, int y) = FindCoords(Quarter);
    System.Console.WriteLine($"Для четверти {Quarter} используйте шаблон координат ({x}, {y})");
}
else
{
    System.Console.WriteLine("Введено некорректное значение, попробуйте снова.");
}