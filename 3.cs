int ameba = 3;
Console.WriteLine("Введите число часов");
int n= Convert.ToInt32(Console.ReadLine());

if (n >= 3)
{
    for (int i = 0; i <= n; i += 3)
    {
        ameba *= 2;

        Console.WriteLine($" Количество амеб - {ameba}");
    }
}
else
{
    Console.WriteLine("Меньше 3 невозможно");
}

