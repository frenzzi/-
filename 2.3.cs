// 2.3
using System;
int i;
string[] W = Console.ReadLine().Split(' ');
int[] Mass = Array.ConvertAll(W, s => int.Parse(s));
int S = Mass[0] + Mass[1] + Mass[2];
for (i = 3; i < Mass.Length - 2; i++)
{
    if (S < Mass[i] + Mass[i + 1] + Mass[i + 2])
    {
        S = Mass[i] + Mass[i + 1] + Mass[i + 2];
    }
}
Console.WriteLine(S);
