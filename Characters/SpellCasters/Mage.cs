using OOPcourseSolutions.Enumerations;
using OOPcourseSolutions.Equipment.Armor.Medium;
using OOPcourseSolutions.Equipment.Weapons.Medium;
using System;


namespace OOPcourseSolutions.Characters.SpellCasters
{
    public class Mage:SpellCasterCharacter
    {
        //characteristics
        private const string DEFAULT_NAME = "Player";
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;

        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 1;

        private readonly Vanguard DEFAULT_ARMOR = new Vanguard();
        private readonly Wand DEFAULT_WEAPON = new Wand();
        
        //equipment
        private Vanguard vanguard;
        private Wand wand;

        public Vanguard Vanguard
        {
            get
            {
                return this.vanguard;
            }
            set
            {
                this.vanguard = value;
            }
        }
        public Wand Wand
        {
            get
            {
                return this.wand;
            }
            set
            {
                this.wand = value;
            }
        }

        public Mage()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
        public Mage(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }
        public Mage(string name, int level, int healthpoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthpoints;
            this.ManaPoints = DEFAULT_ABILITY_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.Vanguard = DEFAULT_ARMOR;
            this.Wand = DEFAULT_WEAPON;
            this.IsAlive = true;
            this.Score = 0;
        }
        public int Fight()
        {
            return this.Wand.DamagePoints + 10;
        }

        public void Ultimate()
        {
            throw new NotImplementedException();

        }

        public int Endurance()
        {
            return this.Vanguard.ArmorPoints + 5;
        }

        public override void Attack()
        {
            this.Fight();
        }

        public override void SpecialAttack()
        {
            this.Ultimate();
        }

        public override void Defend()
        {
            this.Endurance();
        }
    }
}
