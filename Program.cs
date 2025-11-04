// Viết chương trình tính tổng từ 1 đến 10
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Tính tổng các số nguyên từ 1 đến 10
        int sum = 0;
        int i = 1;

        while (i <= 10)
        {
            sum += i; // cộng dồn giá trị i vào sum
            i++;      // tăng i để tiến tới 10
        }

        Console.WriteLine("Tổng từ 1 đến 10 là: " + sum);
    }
}
