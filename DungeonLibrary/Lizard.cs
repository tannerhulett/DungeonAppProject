using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Lizard : Monster
    {
        public int BonusBlock { get; set; }
        public int HidePercent { get; set; }

        public Lizard(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description, int bonusBlock, int hidePercent) : base(name, hitChance, block, maxLife, maxDamage, minDamage, description)
        {
            BonusBlock = bonusBlock;
            HidePercent = hidePercent;
        }

        public Lizard()
        {
            //SET MAX VALUES FIRST!
            MaxLife = 6;
            MaxDamage = 3;
            Life = 6;
            MinDamage = 0;
            HitChance = 5;
            Block = 10;
            Name = "Gex";
            Description = "It's tail time!";
            BonusBlock = 5;
            HidePercent = 10;

        }//end default


        public override string ToString()
        {
            return string.Format("{0}\n{1}% chance it will hide, granting {2} bonus block.",
                base.ToString(), HidePercent, BonusBlock);
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            //Generate a random number from 0-100
            Random rand = new Random();
            int percent = rand.Next(101);

            //Check if that's less than or equal to the hide percent
            if (percent <= HidePercent)
            {
                //If it is, add the bonus block
                calculatedBlock += BonusBlock;
            }

            //Return the total
            return calculatedBlock;
        }

        
    }
}
