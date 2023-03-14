using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        //FIELDS
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        //Added WeaponType enum
        private WeaponType _type;

        //PROPERTIES

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }

        public WeaponType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //MinDamage shouldn't exceed MaxDamage & shouldn't be less than 1
                //if (value > 0 && value <= MaxDamage)
                //{
                //    _minDamage = value;
                //}
                //else
                //{
                //    _minDamage = MaxDamage;
                //}
                _minDamage = value > 0 && value <= MaxDamage ? value : 1;
            }
        }
        public int MaxDamage
        {
            get { return _maxDamage; }
            //max damage should be more than 0.
            set { _maxDamage = value > 0 ? value : 1; }
        }

        //CONSTRUCTORS
        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance,
            bool isTwohanded, WeaponType type)
        {
            //ANY properties with business rules based off of OTHER properties
            //MUST come AFTER those other properties are set. In this case, our 
            //MinDamage has business rules that reference MaxDamage, so we 
            //MUST set MaxDamage FIRST.
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwohanded;
            Type = type;
        }
        public Weapon()
        {

        }
        //METHODS
        public override string ToString()
        {
            return $"{new string('=',Name.Length)}\n" +
                $"{Name}\n" +
                $"{new string('=', Name.Length)}\n" +
                $"{(IsTwoHanded ? "Two-Handed" : "One-Handed")} {Type}\n" +
                $"{MinDamage} to {MaxDamage} Damage\n" +
                $"Bonus Hit: {BonusHitChance}%\n";
        }

        public static Weapon GetWeapon()
        {
            Weapon gun = new Weapon(1, 8, "Ak-47", 10, false, WeaponType.Gun);
            Weapon sword = new Weapon(2, 10, "Fred", 50, true, WeaponType.Sword);
            Weapon dagger = new Weapon(3, 8, "Jamal Dagger", 100, true, WeaponType.Dagger);
            Weapon bow = new Weapon(4, 9, "Semi-Auto Bow", 75, true, WeaponType.Bow);
            Weapon juul = new Weapon(1, 1, "Electronic Cigarette", 1, true, WeaponType.Juul);
            Weapon mace = new Weapon(2, 10, "Normal Mace", 50, true, WeaponType.Mace);
            Weapon axe = new Weapon(2, 10, "Axe Body Spray", 50, true, WeaponType.Axe);
            List<Weapon> weapons = new List<Weapon>(){
                gun, sword, dagger, bow, juul, mace, axe
            };
            return weapons[new Random().Next(weapons.Count)];
        }
    }
}
