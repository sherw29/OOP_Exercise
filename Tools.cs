using System;

namespace OOPcourseSolutions
{
    public static class Tools
    {
        public static void ColorfulWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void TypeSpecificColorfulCW(string message, string type)
        {
            ConsoleColor color = ConsoleColor.White;

            switch (type)
            {
                case "OOPcourseSolutions.Characters.Melee.Warrior":
                    color = ConsoleColor.DarkYellow;
                    break;
                case "OOPcourseSolutions.Characters.Melee.Knight":
                    color = ConsoleColor.Yellow;
                    break;
                case "OOPcourseSolutions.Characters.Melee.Assassin":
                    color = ConsoleColor.Gray;
                    break;
                case "OOPcourseSolutions.Characters.SpellCasters.Mage":
                    color = ConsoleColor.Cyan;
                    break;
                case "OOPcourseSolutions.Characters.SpellCasters.Necromancer":
                    color = ConsoleColor.DarkMagenta;
                    break;
                case "OOPcourseSolutions.Characters.SpellCasters.Druid":
                    color = ConsoleColor.Green;
                    break;
                default:
                    color = ConsoleColor.White;
                    break;
            }

            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }

}
