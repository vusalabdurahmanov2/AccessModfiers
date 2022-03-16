using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTask.Models
{
    class Weapon
    {
        private int _GunBulletCapacity;
        private int _bulletCount;
        private double _bulletShootSecond;
        private bool _autoMode;

        public int BulletCapacity
        {
            get
            {
                if (_GunBulletCapacity > 0) return _GunBulletCapacity; return -1;
            }
            set { _GunBulletCapacity = value; }
        }
        public int BulletCount
        {
            get
            {
                if (_bulletCount > 0) return _bulletCount; return -1;
            }
            set { _bulletCount = value; }
        }
        public double BulletShootSecond
        {
            get
            {
                if (_bulletShootSecond > 0) return _bulletShootSecond; return -1;
            }
            set { _bulletShootSecond = value; }

        }
        public bool AutoMode
        {
            get { return _autoMode; }
            set { _autoMode = value; }
        }

        public Weapon(int bulletCapacity, int bulletCount, double bulletShootSecond, bool autoMode)
        {
            BulletCapacity = bulletCapacity;
            BulletCount = bulletCount;
            BulletShootSecond = bulletShootSecond;
            AutoMode = autoMode;
            if (bulletCount > bulletCapacity)
                Console.WriteLine("Gulle sayi darag tutumundan cox ola bilmez");
        }

        public void Shoot()
        {
            if (_bulletCount != 0)
            {
                Console.WriteLine("pew");
                Console.WriteLine($"Qalan gulle sayi: {--_bulletCount}");
            }
            else
                Console.WriteLine("Daraq bosdur");
        }

        public void Fire()
        {
            double shootedbulletSecond = 0;
            if (_bulletCount != 0)
            {
                shootedbulletSecond = (_bulletCount * _bulletShootSecond) / _GunBulletCapacity;
                _bulletCount = 0;
                Console.WriteLine($"Gulle bosalma saniesi :{} ");
                if (_autoMode == true)
                    Console.WriteLine("pew pew");
                else
                    Console.WriteLine("pew");
            }
            else
                Console.WriteLine("Daraq bosdur");
        }

        public void GetRemainBulletCount()
        {
            if (_GunBulletCapacity == 0 && _GunBulletCapacity > _bulletCount)
            {
                if (_GunBulletCapacity - _bulletCount == 0)
                    Console.WriteLine("Daraq doludur.");
                else
                    Console.WriteLine($"Darağın dolması ücün lazım olan güllə sayı = {_GunBulletCapacity - _bulletCount}");
            }
        }

        public void Reload()
        {
            if (_GunBulletCapacity != 0 && _GunBulletCapacity > _bulletCount)
            {
                if (_GunBulletCapacity - _bulletCount == 0)
                    Console.WriteLine("Daraq doludur");
                else
                {
                    int bullet = _GunBulletCapacity - _bulletCount;
                    _bulletCount = _bulletCount + bullet;
                    Console.WriteLine($"Daraq dolduruldu.Gulle sayi:{_bulletCount}");
                }
            }
            else
                Console.WriteLine("Error");
        }
        public void ChangeFireMode()
        {
            if (_autoMode == false)
            {
                Console.WriteLine("Avtomatik mod aktivdir");
                _autoMode = true;
            }
            else
            {
                Console.WriteLine("Avtomatik mod passivdir");
                _autoMode = false;
            }
        }
    }

}
