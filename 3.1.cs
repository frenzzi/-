// #3.1
int a, b, c, k = 0, days = 365, s;
int[] Month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
if ((c % 400 == 0) | ((c % 4 == 0) & (c % 10 == 0)))
{
    Month[1] = 29;
    days = 366;
}
while (k == 0)
{
    if ((Month[b - 1] < a) | (a <= 0 | b <= 0 | c <= 0))
    {
        Console.WriteLine("Введите другую дату");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Правильная дата");
        k = 1;
    }
}
s = a;
for (int i = 0; i < b - 1; i++)
{
    s += Month[i];
}
Console.WriteLine(s);
Console.WriteLine(days - s);