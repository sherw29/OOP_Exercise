using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcourseSolutions.Equipment.Armor.Medium
{
     public class Vanguard
     {
        private int armorPoints;
        private const int DEFAULT_ARMOR_POINTS = 10;
        public Vanguard()
            : this(DEFAULT_ARMOR_POINTS)
        {
        }
        public Vanguard(int DamagePoints)
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
