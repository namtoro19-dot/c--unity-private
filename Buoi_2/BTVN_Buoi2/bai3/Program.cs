using System;
using System.Diagnostics.Eventing.Reader;

namespace Bai3_TinhDiemTranDau
{
    internal class Program
    { 
        static int CalculateScore(int kills, int assists)
        {
            return kills * 100 + assists * 30;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string bestPlayer = "";
            int highestScore = -1;
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int kills = int.Parse(Console.ReadLine());
                int assists = int.Parse(Console.ReadLine());
                int score = CalculateScore(kills, assists);
                Console.WriteLine($"{name}: {score} score");
                if (score > highestScore)
                {
                    highestScore = score;
                    bestPlayer = name;
                }
            }
            Console.WriteLine($"first place: {bestPlayer}");
            Console.WriteLine($"highest score: {highestScore}");
        }
    }
}