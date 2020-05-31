using OOPcourseSolutions.Enumerations;
using OOPcourseSolutions.Equipment.Armor.Medium;
using OOPcourseSolutions.Equipment.Weapons.Strong;
using System;

namespace OOPcourseSolutions.Characters.Melee
{
    public class Knight:MeleeCharacter
    {
        //characteristics
        private const string DEFAULT_NAME = "Player";
        private const Faction DEFAULT_FACTION = Faction.Melee;

        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 1;

        private readonly Vanguard DEFAULT_ARMOR = new Vanguard();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        
        //equipment
        private Vanguard vanguard;
        private Sword sword;


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
        public Sword Sword
        {
            get
            {
                return this.sword;
            }
            set
            {
                this.sword = value;
            }
        }

        public Knight()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
        public Knight(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }
        public Knight(string name, int level, int healthpoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthpoints;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.Vanguard = DEFAULT_ARMOR;
            this.Sword = DEFAULT_WEAPON;
            this.IsAlive = true;
            this.Score = 0;
        }

        public int Fight()
        {
            return Sword.DamagePoints + 10;
        }

        public void Ultimate()
        {
            throw new NotImplementedException();

        }

        public int Endurance()
        {
            return Vanguard.ArmorPoints + 5;
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
