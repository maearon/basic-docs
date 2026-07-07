// Chức năng: Sắp xếp mảng theo thuật toán Bubble Sort (nổi bọt) - tăng dần
// Nguồn gốc: FPT/Program.cs

using System;
using System.Collections.Generic;

class BubbleSort_SapXepNoiBot
{
    static void Main()
    {
        var a = new List<int> { 1, 5, 2, 3, 7, 6 };
        int n = a.Count;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
        foreach (var item in a)
            Console.WriteLine(item);
    }
}
