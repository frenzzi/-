// 3.2
int n, a, s, m;
int[] month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
int[] month_v = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
n = Convert.ToInt32(Console.ReadLine());
for (int b = 1; b < 13; b++)
{
    if (Math.Abs(1996 - n) % 4 == 0)
    {
        a = month_v[b - 1];
    }
    else
    {
        a = month[b - 1];
    }
    if (n >= 1996)
    {
        s = Convert.ToInt32(Math.Abs(1996 - n) % 4 == 0) * (month_v.Skip(0).Take(b - 1).Sum() + a) + Convert.ToInt32(Math.Abs(1996 - n) % 4 != 0) * (month.Skip(0).Take(b - 1).Sum() + a);
        for (int i = 0; i < n - 1996; i++)
        {
            s += Convert.ToInt32(i % 4 == 0) * 366 + Convert.ToInt32(i % 4 != 0) * 365;
        }
        m = s % 7;
    }
    else
    {
        s = Convert.ToInt32(Math.Abs(1996 - n) % 4 == 0) * (month_v.Skip(b - 1).Sum() - a) + Convert.ToInt32(Math.Abs(1996 - n) % 4 != 0) * (month.Skip(b - 1).Sum() - a);
        for (int i = 1; i < 1996 - n; i++)
        {
            s += Convert.ToInt32(i % 4 == 0) * 366 + Convert.ToInt32(i % 4 != 0) * 365;
        }
        m = (7 - s % 7) % 7;
    }
    Console.WriteLine(a - (m + 3) % 7);
}