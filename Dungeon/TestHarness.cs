using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    internal class TestHarness
    {
        static void Main(string[] args)
        {
            //Build and test the functionality of our Library.
            //Build and test a weapon
            Weapon w1 = new()
            {
                Name = "AK-47",
                MaxDamage = 5,
                MinDamage = 0,//defaults to 1 in the Prop business rules
                BonusHitChance = 10,
                IsTwoHanded = true,
                Type = WeaponType.Gun
            };
            Console.WriteLine("***************** WEAPON *****************");
            Console.WriteLine(w1);
            //Build and test a Character - include CalcBlock(), CalcHitChance(), CalcDamaage()
            Player p1 = new("Tanner MF Hulett", 45, 40, 100, Race.Human, w1);
            Console.WriteLine();
            Console.WriteLine("\n\n***************** PLAYER *****************\n");
            Console.WriteLine(p1);
            Console.WriteLine("CalcBlock: " + p1.CalcBlock());//BLOCK
            Console.WriteLine("CalcHitChance: " + p1.CalcHitChance());//HitChance + Bonus
            Console.WriteLine("CalcDamage: " + p1.CalcDamage());//Random min-max weapon damage

            Console.WriteLine("\n\n***************** MONSTER *****************\n");

            Console.WriteLine(Monster.GetMonster());
            Monster monster = Monster.GetMonster();

            Console.WriteLine("\n\n****************** COMBAT *****************\n");
            Combat.DoBattle(p1, monster);

        }
    }
}
