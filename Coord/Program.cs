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

bool ValidateCoord (int x, int y)
{
    if (x == 0 || y == 0)
    {
        return false;
    }
    return true;
}

int GetQuarter (int x, int y)
{
    if (x>0)
    {
        if (y>0) return 1;
            else return 4;
    }
    else
    {
        if (y>0) return 2;
            else return 3;
    }
}

int x = PromptInt("Введите координату X: ");
int y = PromptInt("Введите координату Y: ");

if (ValidateCoord(x, y))
{
    System.Console.WriteLine($"Координаты ({x},{y}) находятся в {GetQuarter(x,y)} четверти");
}
else
{
    System.Console.WriteLine("Координаты введены неверно, попробуйте снова.");
}