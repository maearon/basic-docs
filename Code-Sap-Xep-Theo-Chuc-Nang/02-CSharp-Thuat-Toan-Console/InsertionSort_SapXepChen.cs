// Chức năng: Sắp xếp mảng theo thuật toán Insertion Sort (chèn) - tăng dần
// Nguồn gốc: FPT/Program.cs

using System;
using System.Collections.Generic;

class InsertionSort_SapXepChen
{
    static void Main()
    {
        var a = new List<int> { 1, 5, 2, 3, 7, 6 };
        int n = a.Count;
        for (int i = 1; i < n; i++)
        {
            int j = i - 1;
            int t = a[i];
            while (j >= 0 && t < a[j])
            {
                a[j + 1] = a[j];
                j--;
            }
            a[j + 1] = t;
        }
        foreach (var item in a)
            Console.WriteLine(item);
    }
}
