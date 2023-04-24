// 3.3
int n, k, k0, otv;
n = Convert.ToInt32(Console.ReadLine());
k = Convert.ToInt32(Console.ReadLine());
Random rnd = new Random();
int ch = rnd.Next(0, n + 1);
k0 = k;
otv = 0;
for (int i = 0; i < k; i++)
{
    otv = Convert.ToInt32(Console.ReadLine());
    if (otv == ch)
    {
        Console.WriteLine("Вы угадали!");
        break;
    }
    if (otv > ch)
    {
        Console.WriteLine("Меньше");
    }
    else
    {
        Console.WriteLine("Больше");
    }
    k0 -= 1;
}
if (k0 <= 0 & otv != ch)
{
    Console.WriteLine("Попытки кончились");
}