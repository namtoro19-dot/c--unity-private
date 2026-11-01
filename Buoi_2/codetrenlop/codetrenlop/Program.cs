using System;
class Program
{
    static void TinhTong()
    {
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        double average = sum / n;
        Console.WriteLine($"Total: {sum}");
        Console.WriteLine($"Average: {average}");
    }

    

    static int CalculateDamage(int attack, int armor)
    {
        int damage = attack - armor;

        if (damage < 0)
        {
            return 0;
        }
        return damage;
    }
    static void Main()
    {
        TinhTong();
        CalculateDamage(20, 5);
        Console.Write("enter choice: ");
        int choice =  int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write(" ");
                break;
    
            case 2:
                Console.Write(" ");
                break;
    
        }
        
    }

    
}

