using System;

class Program
{
    static bool Asalmi(int x)
    {
        bool flag = true;

        if (x == 2)
        {
            return flag;
        }
        else if (x % 2 == 0)
        {
            flag = false;
        }

        if (flag)
        {
            for (int i = 3; i < x / 2; ++i)
            {
                if (x % i == 0)
                {
                    Console.WriteLine($"{x} sayısının {i} sayısına bölümü: {Convert.ToDouble(x) / i}, kalan ise 0'dır.");
                    flag = false;
                    break;
                }
            }
        }

        return flag;
    }

    static void Main()
    {
        Console.Write("Sayı girin: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Asalmi(x));
    }
}
