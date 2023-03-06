using DungeonLibrary;
using DungeonTests;


namespace DungeonTests
{
    public class DungeonTests
    {
        //[Fact]
        //public void TestPlayer()
       // {
            //Arrange
            //Player p1 = new ("Tanner MF Hulett", 45, 40, 100, Race.Human, Weapon WeaponType.Gun);
           // int expectedBlock = 0;
            //int actualBlock = 0;

            //Act
            //expectedBlock = 6;
            //actualBlock = p1.CalcBlock();
            //
            //Assert
           // Assert.Equal(expectedBlock, actualBlock);



       // }

        [Fact]
        public void TestLebron()
        {
            Lebron m1 = new("LeBron James", hitChance: 50, block: 20, maxLife: 25, maxDamage: 8, minDamage: 2,
                description: "What could LeBron being doing here? Shouldn't he be crying about a foul?", true);
            int expectedHit = 0;
            int actualHit = 0;

            //Act
            expectedHit = 30;
            actualHit = m1.CalcBlock();

            //Assert
            Assert.Equal(expectedHit, actualHit);

        }

        [Fact]
        public void TestBugs()
        {
            Bugs m2 = new(name: "Bugs Bunny", hitChance: 70, block: 8, maxLife: 30, maxDamage: 8, minDamage: 1,
                description: "Eh, what's up doc?");
            int expectedDamage = 0;
            int actualDamage = 0;
            
//Act
            expectedDamage = 8;
            actualDamage = m2.CalcDamage();

            //Assert
            Assert.Equal(expectedDamage, actualDamage);
            //Last time ran it was correct its bound to change, by the way i have it setup it will flutcate.

        }

        [Fact]
        public void TestLizard()
        {
            Lizard m3 = new(name: "Gex", hitChance: 50, block: 10, maxLife: 25, maxDamage: 4, minDamage: 1,
                description: "It's tail time!", bonusBlock: 3, hidePercent: 10);
            int expectedBlock = 0;
            int actualBlock = 0;

            //Act
            expectedBlock = 10;
            actualBlock = m3.CalcBlock();

            //Assert
            Assert.Equal(expectedBlock, actualBlock);
        }

        [Fact]
        public void TestPanda()
        {
            Panda m4 = new(name: "Po", hitChance: 65, block: 20, maxLife: 20, maxDamage: 15, minDamage: 1,
                description: "The dragon warrior, form Kung Fu Panda.", isBig: true);
            int expectedHit = 0;
            int actualHit = 0;

            //Act
            expectedHit = 30;
            actualHit = m4.CalcBlock();

            //Assert
            Assert.Equal(expectedHit, actualHit);
        }
        [Fact]
        public void TestPanda2()    
        {
            Panda m4 = new(name: "Po", hitChance: 65, block: 20, maxLife: 20, maxDamage: 15, minDamage: 1,
                description: "The dragon warrior, form Kung Fu Panda.", isBig: true);
            int expectedDamage = 0;
            int actualDamage = 0;

            //Act
            expectedDamage = 4;
            actualDamage = m4.CalcDamage();

            //Assert
            Assert.Equal(expectedDamage, actualDamage);
            // Also fluclates just like the Bugs one.

        }
    }
}