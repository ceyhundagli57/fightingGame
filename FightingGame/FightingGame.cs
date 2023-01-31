using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    class FightingGame
    {
        static void Main(string[] args)
        {

            Hero user; 
            Hero computer; 


            // User selects character
            Console.WriteLine("Choose your character:");
            Console.WriteLine("1) Mage");
            Console.WriteLine("2) Rogue");
            Console.WriteLine("3) Tank");

            int user_character = Convert.ToInt32(Console.ReadLine());

            // Set user's stats for Mage
            if (user_character == 1)
            {
                Console.WriteLine("User chose Mage!");
                user = new Mage();
            }
            // Set user's stats for Rogue
            else if (user_character == 2)
            {
                Console.WriteLine("User chose Rogue!");
                user = new Rogue();
            }
            // Set user's stats for Tank
            else
            {
                Console.WriteLine("User chose Tank!");
                user = new Tank();
            }

            // Computer randomly chooses a character.
            Random rand = new Random();
            int computer_character = rand.Next(1, 4);

            // Announce computer character
            if (computer_character == 1)
            {
                Console.WriteLine("Computer chose Mage!");
                 computer = new Mage();
            }
            else if (computer_character == 2)
            {
                Console.WriteLine("Computer chose Rogue!");

                computer = new Rogue();
            }
            else
            {
                Console.WriteLine("Computer chose Tank!");

                computer = new Tank();
            }

            Console.WriteLine("Fight!!");

            Fight(user, computer);

            // mage: 2 special attacks, weak melee
            // rogue: strong melee + random special attack
            // tank: if blocks special attack, reverses on them

            // block and attack






            void Fight(Hero user, Hero computer)
            {

                // Main gameplay
                while (true)
                {
                    Random rand = new Random();
                    Console.WriteLine("Choose your action: ");
                    Console.WriteLine("1) Block");
                    Console.WriteLine("2) Melee attack");
                    if (user is Mage && user.special_attacks_left > 0)
                    {
                        Console.WriteLine(string.Format("3) Magic attack ({0} left)", user.special_attacks_left));
                    }
                    int user_action = Convert.ToInt32(Console.ReadLine());
                    int computer_action = 0;

                    if (computer is Mage && computer.special_attacks_left > 0)
                    {
                        Console.WriteLine(string.Format("3) Magic attack ({0} left)", computer.special_attacks_left));
                        computer_action = rand.Next(1, 4);
                    }
                    else
                    {
                        computer_action = rand.Next(1, 3);
                    }
                    // Damage only occurs if both user and computer attacked at the same time
                    if (computer_action > 1 && user_action > 1)
                    {
                        // User did melee attack
                        if (user_action == 2)
                        {
                            user.Attack(computer);
                        }
                        // User did magic attack
                        else
                        {
                            if (user is Mage)
                            {
                                user.MagicAttack(computer);
                            }
                        }
                        if (computer.health <= 0)
                        {
                            Console.WriteLine("Computer died. You win!");
                            return;
                        }

                        if (computer_action == 2)
                        {
                            computer.Attack(user);
                        }
                        else
                        {
                            if (computer is Mage)
                            {
                                computer.MagicAttack(user);
                            }
                        }
                        if (user.health <= 0)
                        {
                            Console.WriteLine("User died. Computer win!");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Attack blocked. No damage!!");
                    }

                    Console.WriteLine(string.Format("User health: {0}", user.health));
                    Console.WriteLine(string.Format("Computer health: {0}", computer.health));
                }
            }
        }

      
    }
}
