﻿using System;

namespace Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int k = 1;
            while (k<=num)
            {
                Console.WriteLine(k);
                k = 2 * k + 1;
            }
        }
    }
}
