namespace DungeonLibrary
{
    //"abstract" denotes an "incomplete" class or method. 
    //This tells the program that we will not create any Character objects directly.
    public abstract class Character
    {
        //FIELDS
        private int _life;
        private string _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;

        //PROPERTIES
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= MaxLife)
                {
                    //If trying to set a life value less than or equal
                    //to max life, that's fine.
                    _life = value;
                }
                else
                {
                    //Otherwise, if trying to set life higher than 
                    //max life, set it to their max life value instead.
                    _life = MaxLife;
                }
            }
        }


        //CONSTRUCTORS
        public Character(string name, int hitChance, int block, int maxLife)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life = maxLife;
        }

        public Character()
        {

        }
        //METHODS
        public override string ToString()
        {
            return $"----- {Name} -----\n" +
                $"Life: {Life} of {MaxLife}\n" +
                $"Hit Chance: {HitChance}%\n" +
                $"Block: {Block}";
        }

        public virtual int CalcBlock()
        {
            return Block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }
        public abstract int CalcDamage();//an abstract just says somewhere down the line, one of the child classes MUST implement this with some functionality.
    }
}