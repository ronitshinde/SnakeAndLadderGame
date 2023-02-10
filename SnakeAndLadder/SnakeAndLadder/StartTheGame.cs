using System;

namespace SnakeAndLadder
{
    public class StartTheGame
    {
        public void PlayerOne()
        {
            //UC-1
            int player_no = 1;
            int start_position = 0;
            Console.WriteLine("Start Position of Player no {0} is : {1} ", player_no, start_position);
            Console.ReadLine();

            //UC-2
            Random random = new Random();
            int dice_number = random.Next(1, 7);
            Console.WriteLine("Dice Number : " + dice_number);
            Console.ReadLine();

            //UC-3
            Random random1 = new Random();
            int option = random1.Next(1, 4);
            Console.WriteLine("Number of option " + option);
            Console.Write("\n");
            
            int player_position = 0;
            int no_Play = 0;

            if (option == 1)        //Moves ahead
            {
                player_position = player_position + dice_number;
                Console.WriteLine("Player position moves ahead by the number on dice : " + player_position);
            }
            else if (option == 2)   //Moves behind
            {
                player_position = player_position - dice_number;
                Console.WriteLine("Player position moves behind by the number on dice : " + player_position);
            }
            else                    //No play
            {
                player_position = player_position + no_Play;
                Console.WriteLine("Player position remain same : " + player_position);
            }
            Console.ReadLine();
        }
    }
}
                       
        
