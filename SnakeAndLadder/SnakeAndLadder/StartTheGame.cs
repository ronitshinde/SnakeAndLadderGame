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
                       
        }
    }
}
