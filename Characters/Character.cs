using OOPcourseSolutions.Characters.Interfaces;
using OOPcourseSolutions.Enumerations;
using System;

namespace OOPcourseSolutions.Characters
{
    public abstract class Character:IAttack,IDefend
    {
        private int healthPoints;
        private int level;
        
        private Faction faction;
        private string name;

        private bool isAlive;
        private int score;

        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            set
            {
                this.isAlive = value;
            }
        }
        public int Score
        {
            get
            {
                return this.score;
            }
            set
            {
                this.score = value;
            }
        }


        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 50 && value <= 0)
                    this.healthPoints = value;
                else
                    throw new ArgumentOutOfRangeException("healthPoints", "out of bounds health points should range from 0 to 50");
            }
        }

        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 5 && value <= 0)
                    this.level = value;
                else
                    throw new ArgumentOutOfRangeException("level", "out of bounds level  should range from 0 to 1");
            }
        }

        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this.name = value;
                else
                    throw new ArgumentOutOfRangeException("name", "the character name cannot be empty");
            }
        }

        public abstract int Attack();
        public abstract int SpecialAttack();
        public abstract int Defend();

        public void TakeDamage(int damage, string attackerName, string type)
        {
            if (this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + this.Defend();

                if (this.healthPoints <= 0)
                {
                    this.isAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Haha! Your damage was not enough to harm me!");
            }

            if (!this.isAlive)
            {
                Tools.TypeSpecificColorfulCW($"{this.name} received {damage} damage from {attackerName}, and is now dead!", type);
            }
            else
            {
                Tools.TypeSpecificColorfulCW($"{this.name} received {damage} damage from {attackerName}, and now has {this.healthPoints} healthpoints!", type);
            }
        }

        public void WonBattle()
        {
            this.scores++;

            if (this.scores % 10 == 0)
            {
                this.level++;
            }
        }

    }
}
