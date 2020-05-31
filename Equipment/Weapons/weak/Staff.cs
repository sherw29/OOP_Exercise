using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcourseSolutions.Equipment.Weapons.weak
{
    public class Staff
    {
        private int damagePoints;
        private const int DEFAULT_DAMAGE_POINTS = 10;
        public Staff()
            : this(DEFAULT_DAMAGE_POINTS)
        {
        }
        public Staff(int DamagePoints)
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

        public void Emitt()
        {

        }
    }
}
