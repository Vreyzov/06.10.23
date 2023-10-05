double i;
double composition = 1;
while (true)
{
    Console.WriteLine("Введите число посдедовательности.Для остановки введите 0");
    i = Convert.ToDouble(Console.ReadLine());
    if (i == 0)
    {
        break;
    }
    {
        composition *= i;
    }
}
Console.WriteLine($"Произведение: {composition}");
