﻿using System;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            bool isSpecial = false;
            for (int i = 1; i <= n; i++)
            {
                int digit = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", digit, isSpecial);
                sum = 0;
                i = digit;
            }

        }
    }
}
