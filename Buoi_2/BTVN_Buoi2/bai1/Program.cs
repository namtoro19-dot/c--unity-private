using System;
using System.Diagnostics.Eventing.Reader;   

namespace Bai1_MoPhongTranChien
{
    class Program
    {
        static int CalculateDamage(int attack, int armor)
        {
            int damage = attack -  armor;
            if (damage < 0)
            {
                return 0;
            }
            else
            {
                return damage;
            }
            
        }

        static int CalculateRemainingHp(int currentHp, int damage)
        {
            int remainHp = currentHp - damage;
            if (remainHp < 0)
            {
                return 0; 
            }
            else
            {
                return remainHp; 
            }
        }

        static void Main(string[] args)
        {
            Console.Write("enter initial hp: ");
            int initialHp = int.Parse(Console.ReadLine());
            Console.Write("enter armor: ");
            int armor = int.Parse(Console.ReadLine());
            Console.Write("enter attack n: ");
            int n = int.Parse(Console.ReadLine());
            int[] attacks = new int[n];            //lưu các attack
            for (int i = 0; i < n; i++)
            {
                Console.Write($"enter damage attack {i + 1}: ");
                attacks[i] = int.Parse(Console.ReadLine()); //đọc xong nhét lên thằng new int
                Console.WriteLine($"attack {i + 1} deal {attacks[i]} damage");
            }
            int currentHp = initialHp;
            int totalHpLost = 0;
            int numberofattack = 0;
            int finalHit = 0;
            for (int i = 0; i < n; i++)
            {
                int numberofhit = i + 1; 
                int damage = CalculateDamage(attacks[i], armor);
                int remainHp = CalculateRemainingHp(currentHp, damage);
                int actualHpLost = currentHp - remainHp;
                totalHpLost += actualHpLost; //cộng dồn máu thực tế
                currentHp = remainHp;    //cập nhật máu mới cho hiện tại
                numberofattack++;        //cộng dồn tấn công
                Console.WriteLine($"attack {numberofhit}: damage {damage} | HP {currentHp}");
                if (currentHp == 0)
                {
                    finalHit = numberofhit;
                    break; 
                }
            }
            if (finalHit != 0)
            {
                Console.WriteLine("Status: Taken down");
                Console.WriteLine($"number of attacks deal: {numberofattack}");
                Console.WriteLine($"total HP loss: {totalHpLost}");
                Console.WriteLine($"The Final Blow: {numberofattack}");
            }
            else
            {
                Console.WriteLine("status: alive");
                Console.WriteLine($"number of attacks deal: {numberofattack}");
                Console.WriteLine($"total hp loss: {totalHpLost}");
            }
        }
    }
    
}

