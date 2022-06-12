using System;
namespace Adventure
{
	public class ChapterTwo
	{
		public static void Beginner()
        {
            {
                Console.Clear();
                Console.WriteLine("██ █╬█ ███ ███ ███ ██ ███ ╬╬ ███ █╬╬╬█ ███" +
                    "\n█╬ █▄█ █▄█ █▄█ ╬█╬ █▄ █▄╬ ╬╬ ╬█╬ █╬█╬█ █╬█" +
                    "\n██ █╬█ █╬█ █╬╬ ╬█╬ █▄ █╬█ ╬╬ ╬█╬ █▄█▄█ █▄█");

                int decision;
                Console.WriteLine("Now safely on the ground, you take a moment to assess your surroundings." +
                "\nPiles of clothing are scattered around the room," +
                "\nshoes haphazardly kicked off lie at odd angles near the door." +
                "\nYou look under the bed to see abandoned toys, sporting equipment, and... oh no..." +
                "\nFrom under the bed comes a low growl.");
                Console.WriteLine("\nYour stomach sinks and your eyes go wide as you scan the direction of the sound." +
                    "\nTwo yellow, feline eyes are watching you intently.");
                Console.WriteLine("\nWill you run or hide? Type 1 or 2.");
                Console.Write("Decision: ");
                int.TryParse(Console.ReadLine(), out decision);
                int loop = 0;
                bool caught = false;
                while (decision != 1 && caught == false)
                {
                    if (loop <= 0)
                    {
                        Console.WriteLine("You dart toward the door, but you are too slow. The cat pounces into your path.");
                        Console.WriteLine("You re-evaluate the situation. Will you run or hide? Type 1 or 2");
                        Console.Write("Decision: ");
                        int.TryParse(Console.ReadLine(), out decision);
                        loop++;
                    }
                    else if (loop >= 1)
                    {
                        Console.WriteLine("You dart left toward the closest shoe and climb inside.");
                        Console.WriteLine("The cat follows, swiping the inside of the shoe with its razor sharp claws." +
                            "\nWill you try to escape or continue hiding? Type 1 or 2?");
                        Console.Write("Decision: ");
                        int.TryParse(Console.ReadLine(), out decision);
                        caught = true;
                    }

                }
                if (caught == true)
                {
                    Console.WriteLine("You try to make a run for it, but the cat turns and leaps onto you, capturing you beneath its paws.");
                    Console.WriteLine("Billy's mom comes in to investigate the commotion." +
                        "\nShe gasps and quickly rescues you from the cat, only to return you to your cage.");
                    Console.ReadLine();
                    GameOver.End();
                }
                else

                {
                    Console.WriteLine("You double down on hiding, and burrown as deep as you can into the shoe." +
                        "\nBilly's mom comes in to investigate the commotion." +
                        "\nSeeing the cat with the shoes, she assumes that it is trying to eat the shoelaces " +
                        "\nand shoos the cat away. You live to adventure onward.");
                    Console.ReadLine();
                    ChapterThree.Beginner();
                }
            }
        }

        
    }
}

