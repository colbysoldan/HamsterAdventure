/*
 * Adventure Game
 * by Colby Soldan, June 10, 2022
 * 
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adventure
{
    class Game
    {

    }

    class Item
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Title.GameTitle();

            Console.WriteLine("Get ready for your HAMSTER ADVENTURE!");
            Console.WriteLine("You are a pet hamster looking to find the mystical land of Kichin that your ancestors spoke of round the kibble bowl.");
            Console.ReadLine();


            Console.WriteLine("What would you like your character's name to be?");
            var charName = Console.ReadLine();
            Console.WriteLine($"Great! Your character is now named {charName}.");
        }

        
    }
}

