using System;
namespace Adventure
{
	public class ChapterThree
	{
		public static void Beginner()
        {
            Console.WriteLine("██ █╬█ ███ ███ ███ ██ ███ ╬╬ ███ █╬█ ███ ██ ██" +
                "\n█╬ █▄█ █▄█ █▄█ ╬█╬ █▄ █▄╬ ╬╬ ╬█╬ █▄█ █▄╬ █▄ █▄" +
                "\n██ █╬█ █╬█ █╬╬ ╬█╬ █▄ █╬█ ╬╬ ╬█╬ █╬█ █╬█ █▄ █▄");

            Console.WriteLine("\nYou have survived your fist battle and made it to the threshhold of the bedroom." +
                "\nA hallway lies before you, a vast open space with very little shelter.");

            {
                Random rnd = new Random();
                string[] options = { "You see a china hutch a short distance away, will you run to it and hide?",
            "What is that delicious smell? There's a potato chip on the ground a short distance away. \nBilly must have dropped it. Will you go grab it?",
            "You hear footsteps in the distance.Will you run away from them?"};
                int ranNum = rnd.Next(0, 2);
                string text = options[ranNum];

                string decision;

                Console.WriteLine(text);
                Console.WriteLine("Yes or No?");
                Console.Write("Choice: ");
                decision = Console.ReadLine().ToLower();

                if (decision == "yes" || decision == "y")
                {
                    Console.WriteLine("You feel as if something or someone is stalking you, but decide to ignore the feeling and continue.");
                    Console.ReadLine();
                    Console.Clear();
                    //ChapterFour.Beginner();

                }
                else if (decision == "no" || decision == "n")
                {
                    Console.WriteLine("You stand idle and feel a sharp claw swipe your back , and jagged teeth tear at your legs");
                    Console.WriteLine("All is pain, followed by darkness.");
                    Console.ReadLine();
                    GameOver.End();

                }
                else
                {
                    Console.WriteLine("You must reply Yes or no.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Beginner();
                }

            }
        }

		public static void Normal()
        {

        }

		public static void Hard()
        {

        }
	}
}

