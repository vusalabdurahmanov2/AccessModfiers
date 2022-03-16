using ClassTask.Models;
using System;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MainMenu.AsciiScreen();
            int GunbulletCapacity = -9999999;
            int bulletCount = -99999999;
            int chooseMode = -999999999;
            double bulletShootSecond = -999999999;
            bool autoMode = true;

            MainMenu.CheckStatement(ref GunbulletCapacity, ref bulletCount, ref bulletShootSecond, ref chooseMode, ref autoMode);
            Weapon w = new Weapon(GunbulletCapacity, bulletCount, bulletShootSecond, autoMode);

            int key = 0;
            Console.WriteLine("Progam haqqinda melumat almaq ucun 0 yazin");
            while (key != 6)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 0:
                        Console.WriteLine("Program Haqqinda melumat");
                        Console.WriteLine($"[0]-Info:\n[1]-Shoot\n[2] -Fire\n[3] -GetRemainBulletCount\n[4] -Reload\n[5] -ChangeFireMode\n[6] -Cixis\n[7] -Redakte et");
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        w.Shoot();
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        w.Fire();
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        w.GetRemainBulletCount();
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        w.Reload();
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        w.ChangeFireMode();
                        break;
                    case 6:
                        break;
                    case 7:
                        Console.WriteLine($"T-Gulle tutumun deyismek ucun\nS-Cari gulle sayini deyismek ucunudur\nD -Darağın boşalma saniyəsini dəyişmək üçündür"); ;
                        string letter = Console.ReadLine();
                        switch (letter.ToUpper())
                        {
                            case "T":
                                do//
                                {
                                    Console.WriteLine("Darag tutumunu daxil edin:");
                                    GunbulletCapacity = Convert.ToInt32(Console.Read());
                                    if (w.BulletCapacity > GunbulletCapacity)
                                    {
                                        w.BulletCapacity = GunbulletCapacity;
                                        Console.WriteLine("Daragin tutmuu deyisdirlidi");
                                    }
                                }
                                while (w.BulletCapacity <= 0 || w.BulletCapacity > 2000 || w.BulletCapacity < w.BulletCount);
                                break;
                            case "S":
                                do
                                {
                                    Console.WriteLine("Gulle sayini daxil edin ");
                                    bulletCount = Convert.ToInt32(Console.ReadLine());
                                    while(bulletCount>=w.BulletCapacity)
                                    {
                                        Console.WriteLine("gulle sayi dargain gulle tutumundan cox ola bilmez\nGulle sayini yeni daxil edin");
                                        w.bulletCount =Convert.ToInt32(Console.Read());
                                    }
                                }
                                while (w.BulletCount < 0 || w.BulletCount > w.BulletCapacity);
                                break;
                            case "D":
                                do//
                                {
                                    Console.WriteLine("Sifirlanma saniyesini daxil edin");
                                    w.bulletShootSecond = Convert.ToInt32(Console.ReadLine());
                                } while (w.BulletShootSecond <= 0);
                                break;
                            default:
                                Console.WriteLine("Error");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("yalniz 0-7 araliginda ededlerden istifade ede bilersiniz");
                        break;
                }
            }
        }

    }
}
