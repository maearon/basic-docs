// Chức năng: Tìm phần tử lớn thứ hai trong mảng số nguyên
// Nguồn gốc: FPT/Program.cs

using System;
using System.Collections.Generic;

class TimMaxThuHaiTrongMang
{
    static void Main()
    {
        var a = new List<int> { 1, 5, 2, 3, 7, 6 };
        int max = int.MinValue;
        int second = int.MinValue;
        foreach (var item in a)
        {
            if (item > max) { second = max; max = item; }
            else if (item > second) { second = item; }
        }
        Console.WriteLine(second);
    }
}
