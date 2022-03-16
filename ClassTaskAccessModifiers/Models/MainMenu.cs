using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask.Models
{

    internal class MainMenu
    {
        public static void AsciiScreen()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            string logo = @"____  ___           .__        ________       .__          .__       .__       .__        
\   \/  /____  _____|  |__    /  _____/  ____ |  |   _____ |__| _____|__| ____ |__|_______
 \     //  _ \/  ___/  |  \  /   \  ____/ __ \|  |  /     \|  |/  ___/  |/    \|  \___   /
 /     (  <_> )___ \|   Y  \ \    \_\  \  ___/|  |_|  Y Y  \  |\___ \|  |   |  \  |/    / 
/___/\  \____/____  >___|  /  \______  /\___  >____/__|_|  /__/____  >__|___|  /__/_____ \
      \_/         \/     \/          \/     \/           \/        \/        \/         \/";
            Console.WriteLine(logo);
        }
        public static void CheckStatement(ref int GunbulletCapacity, ref int bulletCount, ref double bulletShootSecond, ref int chooseMode, ref bool autoMode)
        {

            while (GunbulletCapacity <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Darağın maksimum tutumunu daxil edin: ");
                GunbulletCapacity = Convert.ToInt16(Console.ReadLine());
                while (GunbulletCapacity <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Daragin maksimum tutumu 0,(-) ola bilmez yeniden daxil edin:");
                    GunbulletCapacity = Convert.ToInt16(Console.ReadLine());
                }
            }
            while (bulletCount < 0 || bulletCount > GunbulletCapacity)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Hazırda olan gulle sayını daxil edin: ");
                bulletCount = Convert.ToInt16(Console.ReadLine());
                while (bulletCount < 0 || bulletCount > GunbulletCapacity)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Hazirda olan gulle sayi daragin tutumundan cox ola bilmez\nDaragin maksimum tutumu:{GunbulletCapacity}\n Hazirda olan gulle sayini yeniden daxil edin:");
                    bulletCount = Convert.ToInt16(Console.ReadLine());
                }
            }
            while (bulletShootSecond <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Daragin bosalma saniyesini daxil edin  ");
                bulletShootSecond = Convert.ToDouble(Console.ReadLine());
                while (bulletShootSecond <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Saniye 0 veya menfi ola bilmez\nDaragin bosalma saniyesini yeniden daxil edin:");
                    bulletShootSecond = Convert.ToInt16(Console.ReadLine());
                }
            }
            while (true)
            {
                Console.Write("auto modu daxil edin 0 ve ya 1:");
                chooseMode = Convert.ToInt32(Console.ReadLine());
                if (chooseMode == 1)
                {
                    autoMode = true;
                    break;
                }
                else if (chooseMode == 0)
                {
                    autoMode = false;
                    break;
                }
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Yanlis daxil etdiniz yeniden daxil edin:");
            }

        }
    }
}
