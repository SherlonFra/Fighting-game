using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string player1, player2;
            int playerhealth = 100;
            int player2health = 100;
            int kick = 10, punch = 5, energyblast = 20, specialmove = 50;
            int[] moves = new int[4] { kick, punch, energyblast, specialmove};

            Random random = new Random();
            int cpuattack = random.Next(moves.Length);

            
            Console.WriteLine("WELCOME YOU WILL FIGHT TO THE DEATH!!!");
            Console.WriteLine("Player 1: Choose your attack: Kick, Punch, Energyblast, Specialmove ");
            player1 = Console.ReadLine();
            Console.WriteLine("Player 2: Choose your attack: Kick, Punch, Energyblast, Specialmove ");
            player2 = Console.ReadLine();
            player1 = player1.ToLower(); 
            player2 = player2.ToLower();

                    if (player1 == "kick")
                    {
                        Console.WriteLine("Player 2 took " +kick+ " damage. ");
                        Console.WriteLine("Player 2's health is down to " + (player2health - kick)+".");
                        Console.ReadLine();
                    }
                    else if (player1 == "punch")
                    {

                        Console.WriteLine("Player 2 took " +punch+ " damage. ");
                        Console.WriteLine("Player 2's health is down to " + (player2health - punch) +".");
                        Console.ReadLine();
                    }
                    else if (player1 == "energyblast")
                    {

                        Console.WriteLine("Player 2 took " +energyblast+ " damage. ");
                        Console.WriteLine("Player 2's health is down to " + (player2health - energyblast) +".");
                        Console.ReadLine();
                    }
                    else if (player1 == "specialmove")
                    {

                        Console.WriteLine("Player 2 took " +specialmove+ " damage. ");
                        Console.WriteLine("Player 2's health is down to " + (player2health - specialmove) +".");
                        Console.ReadLine();
                    }
                    else
                    {

                    }
            switch (cpuattack)
            {

                case 1:

                     if (player2 == "kick")
                    {
                        Console.WriteLine("Player 1 took " + moves[cpuattack-1] + " damage. ");
                        Console.WriteLine("Player 1's health is down to " + (playerhealth - kick) + ".");
                        Console.ReadLine();
                    }
                
                    else if (player2 == "punch")
                    {

                        Console.WriteLine("Player 1 took " + punch + " damage. ");
                        Console.WriteLine("Player 1's health is down to " + (playerhealth - punch) + ".");
                        Console.ReadLine();
                    }
                    else if (player2 == "energyblast")
                    {

                        Console.WriteLine("Player 1 took " + energyblast + " damage. ");
                        Console.WriteLine("Player 1's health is down to " + (playerhealth - energyblast) + ".");
                        Console.ReadLine();
                    }
                    else if (player2 == "specialmove")
                    {

                        Console.WriteLine("Player 1 took " + specialmove + " damage. ");
                        Console.WriteLine("Player 1's health is down to " + (playerhealth - specialmove) + ".");
                        Console.ReadLine();
                    }
                    else
                    {

                    }
                    break;


            }
        }



    }
}
