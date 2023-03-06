using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DungeonLibrary
{
    public class Lebron : Monster
    {
        public bool IsTall { get; set; }



        //set some values for a basic monster of this type in the 
        //default ctor

        public Lebron(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description, bool isTall) : base(name, hitChance, block, maxLife, maxDamage, minDamage, description)
        {
            IsTall = isTall;
        }
        public Lebron()
        {
            //SET Max Values First!!
            MaxLife = 6;
            MaxDamage = 3;
            Name = "LeBron James";
            Life = 6;
            HitChance = 20;
            Block = 20;
            MinDamage = 1;
            Description = "Oh looks its NBA Legend, Lebron James... why would " +
                "you hurt it?? Now nobody is gonna be able to carry that sorry Lakers team.";
            IsTall = false;
        }

        public override string ToString()
        {
            return base.ToString() + (IsTall ? "Tall" : "Very Tall");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (IsTall)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }

    }
}

    