using System;

namespace Test
{
    internal class Bai1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            Console.WriteLine("Nhap {0} phan tu: ", n);
            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
            int s = 1;
            Console.WriteLine("Cac so le: ");
            foreach (int i in number)
            {
                if (i % 2 == 1)
                {
                    Console.Write("{0} ", i);
                    s *= i;
                }
            }
            Console.WriteLine("\na. Tich cua cac so le: " + s);

            Array.Sort(number);
            Console.WriteLine("b. Phan tu lon thu 2 trong mang: " + number[n - 2]);
        }

    }
}