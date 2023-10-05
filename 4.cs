double i;
int k = 0;
Console.WriteLine("Введите число для поиска:");
double x = Convert.ToDouble(Console.ReadLine());

while (true)
{
    Console.WriteLine("Введите число посдедовательности. Для остановки введите 0");
    i = Convert.ToDouble(Console.ReadLine());
    if (i == 0)
    {
        break;
    }
    if (i == x)
    {
        k += 1;

    }

}
Console.WriteLine($"{k} - Столько раз встречается ваше число в этой последовательности");