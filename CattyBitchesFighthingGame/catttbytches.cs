using System;

namespace CattyBitchesFighthingGame
{
    public class Hoe
    {
        public int hhp = 100;
        public string name = "";

        public hoeWeapon weapon = new hoeWeapon();
        public bool isHoeAlive = true;
    }

    public class hoeWeapon
    {
        public string weaponName = "";
        public int damage = 23;
    }
    
}