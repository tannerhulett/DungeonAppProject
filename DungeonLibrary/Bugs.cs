using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DungeonLibrary
{
    public class Bugs : Monster
    {
        public DateTime TimeCreated { get; set; }

        public Bugs(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description) : base(name, hitChance, block, maxLife, maxDamage, minDamage, description)
        {
            TimeCreated = DateTime.Now;

            if (TimeCreated.Hour < 6 || TimeCreated.Hour > 18)
            {
                HitChance += 10;
                Block += 10;
                MinDamage += 1;
                MaxDamage += 2;
            }
        }

        public Bugs()
        {
            MaxLife = 30;
            MaxDamage = 8;
            Name = "Bugs Bunny";
            Life = 6;
            HitChance = 70;
            Block = 8;
            MinDamage = 1;
            Description = "OMG! It's bugs bunny!";
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}",
                base.ToString(),
                TimeCreated.Hour < 6 || TimeCreated.Hour > 18 ?
                "Classic Looney Tunes character" : "Don't give him a carrot");
        }


    }
}
