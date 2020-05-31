using OOPcourseSolutions.Characters;
using OOPcourseSolutions.Characters.SpellCasters;
using OOPcourseSolutions.Characters.Melee;
using System;
using System.Collections.Generic;

namespace OOPcourseSolutions
{
    public class EntryPoint
    {
        static void Main()
        {
            bool gameOver = false;

            Random rng = new Random();

            MeleeCharacter currentMelee;
            SpellCasterCharacter currentSpellcaster;

            List<MeleeCharacter> meleeTeam = new List<MeleeCharacter>();
            List<SpellCasterCharacter> spellTeam = new List<SpellCasterCharacter>();

            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Knight(),
                new Assassin(),
                new Mage(),
                new Necromancer(),
                new Druid()
            };

            foreach (var character in characters)
            {
                if (character is MeleeCharacter)
                {
                    meleeTeam.Add((MeleeCharacter)character);
                }
                else if (character is SpellCasterCharacter)
                {
                    spellTeam.Add((SpellCasterCharacter)character);
                }
            }

           

            while (!gameOver)
            {
                currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count)];

                currentSpellcaster.TakeDamage(currentMelee.Attack(), currentMelee.Name, currentMelee.GetType().ToString());

                if (!currentSpellcaster.IsAlive)
                {
                    currentMelee.WonBattle();
                    spellTeam.Remove(currentSpellcaster);

                    if (spellTeam.Count == 0)
                    {
                        Tools.ColorfulWriteLine("\nMelee team wins!", ConsoleColor.Red);
                        break;
                    }
                    else
                    {
                        currentSpellcaster = spellTeam[rng.Next(0, spellTeam.Count)];
                    }
                }

                currentMelee.TakeDamage(currentSpellcaster.Attack(), currentSpellcaster.Name, currentSpellcaster.GetType().ToString());

                if (!currentMelee.IsAlive)
                {
                    currentSpellcaster.WonBattle();
                    meleeTeam.Remove(currentMelee);

                    if (meleeTeam.Count == 0)
                    {
                        Tools.ColorfulWriteLine("\nSpell team wins!", ConsoleColor.Red);

                        break;
                    }
                    else
                    {
                        currentMelee = meleeTeam[rng.Next(0, meleeTeam.Count)];
                    }
                }
            }

           
        }
    }
}
