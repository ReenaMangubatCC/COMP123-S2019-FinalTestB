﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * STUDENT NAME: Reena Mangubat
 * STUDENT ID: 301000701
 * DESCRIPTION: This is the Character class used in the character creation
 * This is also the Data container for the application.
 */
namespace COMP123_S2019_FinalTestB.Objects
{
    public class Character
    {
        //Identity
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Character Abilities
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Constitution { get; set; }
        public string Intelligence { get; set; }
        public string Wisdom { get; set; }
        public string Charisma { get; set; }

        //Secondary abilities
        public int ArmourClass { get; set; }
        public int HitPoints { get; set; }

        //Character Class
        public CharacterClass Class { get; set; }
        public int Level { get; set; }

        //Equipment
        List<string> Inventory;


        //Constructor 
        public Character()
        {
            this.Inventory = new List<string>();
        }



    }
}
