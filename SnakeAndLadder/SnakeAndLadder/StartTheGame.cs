using System;

namespace SnakeAndLadder
{
    public class StartTheGame
    {
        public void PlayerOne()
        {
            //UC-6
            int player_position = 0;
            int no_Play = 0;
            int die_Count = 0;
            while (player_position <= 100)

            {
                //Get dice number
                Random random = new Random();
                int dice_number = random.Next(1, 7);
                Console.WriteLine("Number on dice : " + dice_number);
                die_Count++;

                //Get the move to play
                Random random1 = new Random();
                int option = random1.Next(1, 4);
                Console.WriteLine("Number of option " + option);
              
                if (option == 1)        //Moves ahead using Ladder
                {
                    player_position = player_position + dice_number;

                    if (player_position == 100)
                    {
                        Console.WriteLine("Player position is {0} and \" Player has won \" ", player_position);
                        break;
                    }
                    else if (player_position > 100)
                    {
                        player_position = player_position - dice_number;
                    }

                    Console.WriteLine("Player position moves ahead by {0} : {1}", dice_number, player_position);
                }

                else if (option == 2)       //Moves behind using Snake
                {
                    player_position = player_position - dice_number;

                    if (player_position < 0)
                    {
                        player_position = 0;
                        Console.WriteLine("Player starts again from 0 position");
                    }

                    Console.WriteLine("Player position moves behind by {0} : {1}", dice_number, player_position);
                }
                
                else                   //No play
                {
                    player_position = player_position + no_Play;
                    Console.WriteLine("Player position remain same : " + player_position);
                }
            }
            Console.WriteLine("Total dies played in the game : " + die_Count);
            Console.ReadLine();
        }
    }
}
