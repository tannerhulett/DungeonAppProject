using DungeonLibrary;

namespace Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Title/Introduction
            Console.Title = "Tanner VS Everybody: The Game";
            Console.WriteLine("Are you ready...\n");
            #endregion

            #region Player Creation
            //Variable to keep score
            int score = 0;
            //Weapon creation
            //Possible Expansion - Display a list of pre-created weapons and let them pick one.
            //Or, pick one for them randomly.
            Weapon gun = new Weapon(1, 8, "Ak-47", 10, false, WeaponType.Gun);

            //Player Object creation
            //Potential Expansion - Allow them to enter their own name.
            //Show them the possible races and let them pick one.
            Player player = new("Tanner MF Hulett", 70, 5, 40, Race.Human, gun);
            #endregion

            #region Main Game Loop
            bool exit = false;
            do
            {
                //Generate a random room
                Console.WriteLine(GetRoom());
                //Select a random monster to inhabit the room
                Monster monster = Monster.GetMonster();
                Console.WriteLine($"Prepare yourself for {monster.Name}!");
                #region Gameplay Menu Loop
                bool reload = false;
                do
                {
                    //Gameplay Menu
                    #region Menu
                    Console.Write("\nPlease choose an action:\n" +
                       "A) Attack\n" +
                       "R) Run away\n" +
                       "P) Player Info\n" +
                       "M) Monster Info\n" +
                       "X) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            //Combat
                            //Potential Expansion : weapon/race bonus attack
                            //if race == darkelf -> player.DoAttack(monster)
                            Combat.DoBattle(player, monster);
                            //check if the monster is dead
                            if (monster.Life <= 0)
                            {
                                //Combat rewards -> money, health, whatever
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nYou killed {monster.Name}!");
                                Console.ResetColor();
                                //flip the inner-loop bool to true
                                reload = true;

                                score++;
                            }
                            break;

                        case ConsoleKey.R:
                            //Attack of Opportunity
                            Console.WriteLine("Run away!!");
                            Console.WriteLine($"{monster.Name} attacks you as you flee!");
                            Combat.DoAttack(monster, player);
                            Console.WriteLine();//formatting
                            reload = true;//new room, new monster
                            break;

                        case ConsoleKey.P:
                            //Player info
                            Console.WriteLine("Player Info: ");
                            Console.WriteLine(player);
                            break;

                        case ConsoleKey.M:
                            //Monster info
                            Console.WriteLine("Monster info: ");
                            Console.WriteLine(monster);
                            break;

                        case ConsoleKey.X:
                        case ConsoleKey.E:
                        case ConsoleKey.Escape:
                            Console.WriteLine("No one likes a quitter...");
                            exit = true;
                            //reload = true;
                            break;
                        default:
                            break;
                    }//end switch

                    #endregion
                    // Check player life
                    if (player.Life <= 0)
                    {
                        Console.WriteLine("BooHoo You lose...\a");
                        exit = true;
                    }

                } while (!reload && !exit); //If either exit or reload is true, the inner loop will exit.
                #endregion
            } while (!exit);//If exit is true, the outer loop will exit as well.

            //Show the score
            Console.WriteLine("You defeated " + score + " monster" +
                (score == 1 ? "." : "s."));

            #endregion
        }//end Main()

        private static string GetRoom()
        {
            string[] rooms =
            {
                "This room smells funny, what is that smell...",
                "Ooga-Chaka Ooga-Ooga, I can't stop this feeling... Deep inside of meee!",
                "*static noise*",
                "That's as much fun as being Mike Tyson's cell-mate on Valentines day!",
                "Note to self, don't drink tap water at Jerry Garcia's.",
                "Here's Tanner!!",
                "Captian, I've found a bizarre alien race that finds Adam Sandler Funny.",
                "This looks like an all-nighter at Richard Simon's House.",
                "This is what Tim Burton thinks about when he's in the tub.",
            };

            Random rand = new Random();

            int index = rand.Next(rooms.Length);

            string room = rooms[index];

            return room;
            //possible refactor
            //return rooms[new Random().Next(rooms.Length)];
        }//end GetRoom()

    }//end class
}//end namespace