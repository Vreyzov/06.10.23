double i;
double sum = 0;
while (true)
{
    Console.WriteLine("Введите число посдедовательности.Для остановки введите 0");
    i = Convert.ToDouble(Console.ReadLine());
    if (i == 0)
    {
        break;
    }
    {
        sum += i;
    }
}
Console.WriteLine($"Сумма: {sum}");
