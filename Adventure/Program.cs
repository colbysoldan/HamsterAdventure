/*
 * Adventure Game
 * by Colby Soldan, June 10, 2022
 * 
 * 
 * Title text from textartgenerator.net
 * 
 * Text images adapted from textart.sh
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adventure
{
    class Program
    {
       static void Main(string[] args)
        {
            //Title and welcome
            Title.GameTitle();

            //Choose character name
            SetUp.GameSetUp();

            Return();

            Console.Clear();

            //choose difficulty
            Difficulty.Choice();

        }

        public static void Return()
        {
            //This meathod is used as a shortcut so that I don't have to type these two lines of code repeatedly.
            Console.WriteLine("Press \'Return\' to continue");
            Console.ReadLine();
        }

        
        
    }
}

