using OOPcourseSolutions.Enumerations;
using OOPcourseSolutions.Equipment.Armor.Light;
using OOPcourseSolutions.Equipment.Weapons.Medium;
using System;

namespace OOPcourseSolutions.Characters.Melee
{
    public class Assassin:MeleeCharacter
    {
        //characteristics
        private const string DEFAULT_NAME = "Assassin";
        private const Faction DEFAULT_FACTION = Faction.Melee;

        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 1;

        private readonly CrimsonGuard DEFAULT_ARMOR = new CrimsonGuard();
        private readonly Scythe DEFAULT_WEAPON = new Scythe();

        
        
        //equipment
        private CrimsonGuard crimsonGuard;
        private Scythe scythe;

        public CrimsonGuard CrimsonGuard
        {
            get
            {
                return this.crimsonGuard;
            }
            set
            {
                this.crimsonGuard = value;
            }
        }
        public Scythe Scythe
        {
            get
            {
                return this.scythe;
            }
            set
            {
                this.scythe = value;
            }
        }

        public Assassin()
           : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
        public Assassin(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }
        public Assassin(string name, int level, int healthpoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthpoints;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.CrimsonGuard = DEFAULT_ARMOR;
            this.Scythe = DEFAULT_WEAPON;
            this.IsAlive = true;
            this.Score = 0;
        }

        public int Fight()
        {
            return Scythe.DamagePoints + 10;
        }

        public void Ultimate()
        {
            throw new NotImplementedException();

        }

        public int Endurance()
        {
            return CrimsonGuard.ArmorPoints + 5; 
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
