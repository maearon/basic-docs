// Chức năng: Sắp xếp mảng theo thuật toán Selection Sort (chọn) - tăng dần
// Nguồn gốc: FPT/Program.cs

using System;
using System.Collections.Generic;

class SelectionSort_SapXepChon
{
    static void Main()
    {
        var a = new List<int> { 1, 5, 2, 3, 7, 6 };
        int n = a.Count;
        for (int i = 0; i < n - 1; i++)
        {
            int min = a[i];
            for (int j = i + 1; j < n; j++)
                if (a[j] < min)
                {
                    min = a[j];
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
        }
        foreach (var item in a)
            Console.WriteLine(item);
    }
}
