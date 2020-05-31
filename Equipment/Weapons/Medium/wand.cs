using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcourseSolutions.Equipment.Weapons.Medium
{
    public class Wand
    {
        private int damagePoints;
        private const int DEFAULT_DAMAGE_POINTS = 10;
        public Wand()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }
        public Wand(int DamagePoints)
        {
            this.damagePoints = DamagePoints;
        }
        public int DamagePoints
        {
            get
            {
                return this.damagePoints;
            }
            set
            {
                this.damagePoints = value;
            }
        }

        public void CasteSpell()
        {

        }
    }
}
