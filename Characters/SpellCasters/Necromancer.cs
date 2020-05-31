using OOPcourseSolutions.Enumerations;
using OOPcourseSolutions.Equipment.Armor.Heavy;
using OOPcourseSolutions.Equipment.Weapons.weak;
using System;


namespace OOPcourseSolutions.Characters.SpellCasters
{
    public class Necromancer:SpellCasterCharacter
    {
        //characteristics
        private const string DEFAULT_NAME = "Player";
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;

        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 1;

        private readonly SummoningArmor DEFAULT_ARMOR = new SummoningArmor();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        
        //equipment
        private Staff staff;
        private SummoningArmor summoningArmor;

        public Staff Staff
        {
            get
            {
                return this.staff;
            }
            set
            {
                this.staff = value;
            }
        }
        public SummoningArmor SummoningArmor
        {
            get
            {
                return this.summoningArmor;
            }
            set
            {
                this.summoningArmor = value;
            }
        }

        public Necromancer()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
        public Necromancer(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }
        public Necromancer(string name, int level, int healthpoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthpoints;
            this.ManaPoints = DEFAULT_ABILITY_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.SummoningArmor = DEFAULT_ARMOR;
            this.Staff = DEFAULT_WEAPON;
            this.IsAlive = true;
            this.Score = 0;
        }
        public int Fight()
        {
            return this.Staff.DamagePoints + 10;
        }

        public void Ultimate()
        {
            throw new NotImplementedException();

        }

        public int Endurance()
        {
            return this.SummoningArmor.ArmorPoints + 5;
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
