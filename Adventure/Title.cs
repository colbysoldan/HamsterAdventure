using System;
namespace Adventure
{
	public class Title
	{
		public static void GameTitle()
		{
			//Title Image
			Console.WriteLine("█┼█ ███ █▄┼▄█ ███ ███ ███ ███ ┼┼ ███ ██▄ █▄█ ███ █┼┼█ ███ █┼█ ███ ███");
			Console.WriteLine("█▄█ █▄█ █┼█┼█ █▄▄ ┼█┼ █▄┼ █▄┼ ┼┼ █▄█ █┼█ ███ █▄┼ ██▄█ ┼█┼ █┼█ █▄┼ █▄┼");
			Console.WriteLine("█┼█ █┼█ █┼┼┼█ ▄▄█ ┼█┼ █▄▄ █┼█ ┼┼ █┼█ ███ ┼█┼ █▄▄ █┼██ ┼█┼ ███ █┼█ █▄▄");

			//Introductory Text
			Console.WriteLine("Get ready for your HAMSTER ADVENTURE!");
			Console.WriteLine("You are a pet hamster looking to find the mystical land of Kichin " +
                "that your ancestors spoke of 'round the kibble bowl.");
			Console.WriteLine("Press \'Return\' to begin");
			Console.ReadLine();

		}
	}
}

