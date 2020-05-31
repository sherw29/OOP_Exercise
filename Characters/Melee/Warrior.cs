using OOPcourseSolutions.Enumerations;
using OOPcourseSolutions.Equipment.Armor.Heavy;
using OOPcourseSolutions.Equipment.Weapons.weak;
using System;

namespace OOPcourseSolutions.Characters.Melee
{
    public class Warrior:MeleeCharacter
    {
        //characteristics
        private const string DEFAULT_NAME = "Player";
        private const Faction DEFAULT_FACTION = Enumerations.Faction.Melee;

        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_LEVEL = 1;

        private readonly SummoningArmor DEFAULT_ARMOR = new SummoningArmor();
        private readonly OgreAxe DEFAULT_WEAPON = new OgreAxe();
        
        //equipment
        private SummoningArmor summoningArmor;
        private OgreAxe orgeAxe;

        public SummoningArmor SummoningArmor 
        {   get
            {
                return this.summoningArmor;
            }
            set 
            {
                this.summoningArmor = value;
            }
        }
        public OgreAxe OgreAxe
        {
            get
            {
                return this.orgeAxe;
            }
            set
            {
                this.OgreAxe = value;
            }
        }

        public Warrior()
           : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
        public Warrior(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }
        public Warrior(string name, int level, int healthpoints)
        {
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthpoints;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Faction = DEFAULT_FACTION;
            this.SummoningArmor = DEFAULT_ARMOR;
            this.OgreAxe = DEFAULT_WEAPON;
            this.IsAlive = true;
            this.Score = 0;
        }



        public int Fight()
        {
            return this.OgreAxe.DamagePoints + 10;
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
