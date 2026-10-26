using System;
using System.Globalization;

namespace Bai2_TheNhanVat
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int hp = int.Parse(Console.ReadLine());
            float speed = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            char rank = char.Parse(Console.ReadLine());
            bool isAlive = hp > 0;
            

            Console.WriteLine($"Ten: {name}");
            Console.WriteLine($"HP: {hp}");
            Console.WriteLine($"Toc do: {speed.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Hang: {rank}");
            Console.WriteLine($"Con song: {isAlive}");
        }
    }
}