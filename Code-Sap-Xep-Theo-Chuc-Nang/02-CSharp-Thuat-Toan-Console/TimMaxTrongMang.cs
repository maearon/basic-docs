// Chức năng: Tìm phần tử lớn nhất trong mảng số nguyên
// Nguồn gốc: FPT/Program.cs

using System;
using System.Collections.Generic;

class TimMaxTrongMang
{
    static void Main()
    {
        var a = new List<int> { 1, 5, 2, 3, 7, 6 };
        int max = a[0];
        for (int i = 1; i < a.Count; i++)
            if (a[i] > max) max = a[i];
        Console.WriteLine(max);
    }
}
