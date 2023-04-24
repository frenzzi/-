// 2.2
using System;
int R0;
int R1 = Convert.ToInt32(Console.ReadLine());
int R2 = Convert.ToInt32(Console.ReadLine());
string Type = Console.ReadLine();
if (Type == "последовательное")
{
    R0 = R1 + R2;
    Console.WriteLine(R0);
}
else
{
    R0 = (R1 * R2) / (R1 + R2);
    Console.WriteLine(R0);
}
