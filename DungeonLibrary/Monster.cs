using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //make it public!
    //Make it a child of character
    public class Monster : Character
    {
        private int _minDamage;

        public int MaxDamage { get; set; }
        public string Description { get; set; } = null!;

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value <= MaxDamage ? value : MaxDamage; }
        }

        public Monster(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description)
            : base(name, hitChance, block, maxLife)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }
        public Monster()
        {

        }
        public override string ToString()
        {
            return base.ToString() + $"\nDamage: {MinDamage} to {MaxDamage}\nDescription: {Description}\n";
        }
        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }
        public static Monster GetMonster()
        {
            // Create a variety of monsters
            Lebron m1 = new("LeBron James", hitChance: 50, block: 20, maxLife: 25, maxDamage: 8, minDamage: 2,
                description: "What could LeBron being doing here? Shouldn't he be crying about a foul?", true);
            Bugs m2 = new(name: "Bugs Bunny", hitChance: 70, block: 8, maxLife: 30, maxDamage: 8, minDamage: 1,
                description: "Eh, what's up doc?");
            Lizard m3 = new(name: "Gex", hitChance: 50, block: 10, maxLife: 25, maxDamage: 4, minDamage: 1,
                description: "It's tail time!", bonusBlock: 3, hidePercent: 10);
            Panda m4 = new(name: "Po", hitChance: 65, block: 20, maxLife: 20, maxDamage: 15, minDamage: 1,
                description: "The dragon warrior, form Kung Fu Panda.", isBig: true);

            Lizard babyLizard = new();
            Panda babyPanda = new();
            Lebron babyLebron = new();
            Bugs babyBugs = new();

            //Add the monsters to a collection
            List<Monster> monsters = new()
            {
               m1,
               babyLizard,babyLizard,babyLizard,
               m2, 
               babyPanda,babyPanda,babyPanda,
               m3, 
               babyLebron,babyLebron,babyLebron,
               m4,
               babyBugs,babyBugs,babyBugs
            };
            //Pick one at random to place in our dungeon room
            return monsters[new Random().Next(monsters.Count)];
        }
    }
}
