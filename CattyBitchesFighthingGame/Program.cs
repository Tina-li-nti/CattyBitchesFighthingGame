using System;

namespace CattyBitchesFighthingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Hoe hoe = new Hoe();
            Hoe hoe1 = new Hoe();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to THE CATTY BITCHES FiGHTING GAME");
            Console.WriteLine("Name your fighter.....");
            hoe.name = Console.ReadLine();
            hoe1.name = "rachel";
            Console.WriteLine("This hoe just took your man. Press 1 to fight, or press 2 to fight");
            Console.WriteLine("Choose your weapon...");
            hoe.weapon.weaponName = Console.ReadLine();
            hoe1.weapon.weaponName = "long nails";
            ConsoleKey key = ConsoleKey.A;
            while (key != ConsoleKey.D1 && key != ConsoleKey.D2)
            {
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.D1)
                {
                    while (hoe.hhp > 0 && hoe1.hhp > 0)
                    {
                        hoe.hhp = -hoe1.weapon.damage;
                        hoe1.hhp = -hoe.weapon.damage;
                        Console.WriteLine("You have " + hoe.hhp + "HP, and " + hoe1.name + "has " + hoe1.hhp + " HP.");
                        if (hoe1.hhp > 0)
                        {
                            Console.WriteLine(hoe1.name + " is DEAD");
                        }
                        if (hoe.hhp > 0)
                        {
                            Console.WriteLine(hoe.name + " is DEAD");
                        }
                    }
                }
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.D2)
                {
                    hoe.hhp = -hoe1.weapon.damage;
                    hoe1.hhp = -hoe.weapon.damage;
                    Console.WriteLine("You have " + hoe.hhp + "HP, and " + hoe1.name + "has " + hoe1.hhp + " HP.");
                }

            }


            Console.ReadLine();
        }
    }
}
