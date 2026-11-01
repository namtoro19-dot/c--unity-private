using System;
using System.Diagnostics.Eventing.Reader;

namespace Bai2_ThongKeSatThuong
{
    class Program
    {
        static int CalculateTotalDamage(int[] damages)
        {
            int totalDamage = 0;
            for(int i = 0; i < damages.Length; i++)
            {
                totalDamage += damages[i];
            }
            return totalDamage;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] damages = new int[n];
            for (int i = 0; i < n; i++)
            {
                damages[i]  = int.Parse(Console.ReadLine());
            }
            int totalDamage = CalculateTotalDamage(damages);
            int hitsCount = 0;     
            int missesCount = 0;    
            int maxDamage = damages[0]; 
            for (int i = 0; i < n; i++)
            {
                if (damages[i] > 0)
                {
                    hitsCount++;
                }
                else
                {
                    missesCount++;
                }
                if (damages[i] > maxDamage)
                {
                    maxDamage = damages[i];
                }
            }
            Console.WriteLine($"total damage: {totalDamage}");
            Console.WriteLine($"hit count: {hitsCount}");
            Console.WriteLine($"miss count: {missesCount}");
            Console.WriteLine($"max damage: {maxDamage}");
        }
    }
}