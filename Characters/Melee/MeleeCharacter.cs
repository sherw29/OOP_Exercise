using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcourseSolutions.Characters
{
    public abstract class MeleeCharacter:Character
    {
        private int abilityPoints;
        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 10 && value <= 0)
                    this.abilityPoints = value;
                else
                    throw new ArgumentOutOfRangeException("abiltyPoints", "out of bounds, ability points should range from 0 to 10");
            }
        }
    }
}
