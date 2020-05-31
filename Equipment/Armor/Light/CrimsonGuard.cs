using OOPcourseSolutions.Equipment.Armor.Medium;
using OOPcourseSolutions.Equipment.Weapons.Strong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcourseSolutions.Equipment.Armor.Light
{
    public class CrimsonGuard
    {
        private int armorPoints;
        private const int DEFAULT_ARMOR_POINTS = 10;
        public CrimsonGuard()
            : this(DEFAULT_ARMOR_POINTS)
        {
        }
        public CrimsonGuard(int DamagePoints)
        {
            this.ArmorPoints = DamagePoints;
        }

        public int ArmorPoints
        {
            get
            {
                return this.armorPoints;
            }
            set
            {
                this.armorPoints = value;
            }
        }
    }
}
