// Определить количество цифр в числе

Console.Clear();
Console.Write("Ввведите число: ");
int i = int.Parse(Console.ReadLine());
int res = i;
int n = 0;
while (i > 0)
{
      i = i  / 10;
      n++;
}

Console.WriteLine($"В числе {res} - {n} цифр.");