using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DungeonLibrary
{
    public class Panda : Monster
    {
        public bool IsBig { get; set; }


        public Panda(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description, bool isBig) : base(name, hitChance, block, maxLife, maxDamage, minDamage, description)
        {
            IsBig = isBig;
        }

        public Panda()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Name = "Po";
            Life = 6;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "Kung Fu Panda";
            IsBig = false;
        }


        public override string ToString()
        {
            return base.ToString() + (IsBig ? "BIg fluffy guy" : "Don't under estimate him.");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (IsBig)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }

        
    }
}
