// Chức năng: Liệt kê các số nguyên tố từ 1 đến 7
// Nguồn gốc: FPT/Program.cs

using System;

class TimSoNguyenTo
{
    static void Main()
    {
        for (int i = 1; i <= 7; i++)
        {
            bool isPrime = true;
            for (int j = 2; j < i; j++)
                if (i % j == 0) { isPrime = false; break; }
            if (isPrime) Console.WriteLine(i);
        }
    }
}
