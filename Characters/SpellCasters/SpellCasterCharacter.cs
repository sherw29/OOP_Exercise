using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcourseSolutions.Characters
{
    public abstract class SpellCasterCharacter:Character
    {
        private int manaPoints;
        public int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }
            set
            {
                if (value >= 10 && value <= 0)
                    this.manaPoints = value;
                else
                    throw new ArgumentOutOfRangeException("manaPoints", "out of bounds,manapoints should range from 0 to 10");
            }
        }
    }
}
