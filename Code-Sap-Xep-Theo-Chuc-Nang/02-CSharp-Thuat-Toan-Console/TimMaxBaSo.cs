// Chức năng: Tìm số lớn nhất trong ba số a, b, c
// Nguồn gốc: FPT/Program.cs

using System;

class TimMaxBaSo
{
    static void Main()
    {
        int a = 1, b = 3, c = 2;
        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        Console.WriteLine(max);
    }
}
