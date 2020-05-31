
using OOPcourseSolutions.Enumerations;
using OOPcourseSolutions.Equipment.Armor.Light;
using OOPcourseSolutions.Equipment.Weapons.Strong;
using System;


namespace OOPcourseSolutions.Characters.SpellCasters
{
    public class Druid:SpellCasterCharacter
    {
        //characteristics
        private const string DEFAULT_NAME = "Player";
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;

        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 1;

        private readonly CrimsonGuard DEFAULT_ARMOR = new CrimsonGuard();
        private readonly Canon DEFAULT_WEAPON = new Canon();
        
        //equipment
        private CrimsonGuard crimsonGuard;
        private Canon canon;

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
        public Canon Canon
        {
            get
            {
                return this.canon;
            }
            set
            {
                this.canon = value;
            }
        }

        public Druid()
            : this(DEFAULT_NAME,DEFAULT_LEVEL)
        {
        }
        public Druid(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }
        public Druid(string name, int level, int healthpoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthpoints;
            this.ManaPoints = DEFAULT_ABILITY_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.CrimsonGuard = DEFAULT_ARMOR;
            this.Canon = DEFAULT_WEAPON;
            this.IsAlive = true;
            this.Score = 0;
        }
        public int Fight()
        {
            return this.Canon.DamagePoints + 10;
        }

        public void Ultimate()
        {
            throw new NotImplementedException();

        }

        public int Endurance()
        {
            return this.CrimsonGuard.ArmorPoints + 5;
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
