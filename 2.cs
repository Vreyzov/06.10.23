double distance = 10;
double sum = 10;
Console.WriteLine("Введите число дней");
int S = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < S; i++)
{
    distance *= 1.1;
    sum += distance;
}
Console.WriteLine($"Спортсмен пробежал {sum} км");