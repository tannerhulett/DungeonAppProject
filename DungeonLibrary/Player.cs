using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        //Fields

        //Props
        public Race PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }

        //CTORS/Constructors
        public Player(string name, int hitChance, int block, int maxLife, Race playerRace, Weapon equippedWeapon) 
            : base(name, hitChance, block, maxLife)
        {
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;

            #region Potential Expansion - Racial Bonuses
            switch (PlayerRace)
            {
                case Race.Elf:
                    HitChance += 5;
                    break;               
            }            
            #endregion
        }

        //Methods
        public override string ToString()
        {
            //create a string, switch on Player Race and 
            //write some description about that race.
            string description = PlayerRace.ToString();
            return base.ToString() + $"\nWeapon: \n{EquippedWeapon}\n" +
                $"Description: {description}";
        }
        public override int CalcDamage()
        {
            //Create a Random object
            Random rand = new Random();
            //determine the damage
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            //return the damage
            return damage;
        }

        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }
    }
}
