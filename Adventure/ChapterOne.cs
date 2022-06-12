using System;
namespace Adventure
{
	public class ChapterOne
	{
		public static void Beginner()
		{
			Console.WriteLine("██ █╬█ ███ ███ ███ ██ ███ ╬╬ ███ █╬╬█ ██" +
"\n█╬ █▄█ █▄█ █▄█ ╬█╬ █▄ █▄╬ ╬╬ █╬█ ██▄█ █▄" +
"\n██ █╬█ █╬█ █╬╬ ╬█╬ █▄ █╬█ ╬╬ █▄█ █╬██ █▄");

			Program.Return();

			Console.WriteLine("Billy has taken your water bottle for a refill" +
				"\nand carelessly left your door askew.");
			Console.WriteLine("Now is your chance to make your move!\n");
			Console.WriteLine("You see a pair of pants hanging from the top drawer." +
				"\nIf you scale down them you should be able to drop to the floor safely." +
				"\nThe only other option is to jump from the dresser and hope you" +
				"\nland on a pillow below. " +
				"\nWhat do you choose?" +
				"\n1. Pants" +
				"\n2. Jump");
			var choice = Console.ReadLine().ToLower();
			Console.Clear();

			switch (choice)
			{
				case "1":
				case "pants":
				case "1.":
					{
						Console.WriteLine("You climb quietly from your cage and look over the edge of the dresser.");
						Console.WriteLine("You can see the leg of the pants hanging down, ");
						Console.WriteLine("so you lean over the edge to grab on with your paw.");
						Console.WriteLine("You shift forward and roll off of the dresser.");
						Console.WriteLine("For a moment, your paw slips and you think you may fall," +
                            "\nbut you dig in with all four paws and regain your control" +
                            "\nbefore scurrying down to the ground.");
						Program.Return();
						ChapterTwo.Beginner();
						break;
					}

				case "2":
				case "jump":
				case "2.":
                    {
						Console.WriteLine("You climb quietly from your cate and look over the edge of the dresser." +
                            "\nSuddenly your home seems much further from the ground than you remembered." +
                            "\nThe pillow lies a little bit further from the dresser than you would like." +
                            "\nYou crouch down and brace for the jump, then launch off into a free fall." +
                            "\nIt lasts only a few seconds, but you feel like time slows around you." +
                            "\nThe ground becomes ever closer, and you wonder if you've made your last mistake." +
                            "\nBut alas! You feel your body land sofly in the center of the pillow.");
						Program.Return();
						ChapterTwo.Beginner();
						break;
                    }
				default:
					{

						Console.WriteLine("Command is invalid...");
						Console.WriteLine("Press 'Enter' to retry.");
						Console.ReadLine();
						Beginner();
						break;
					}

			}

		}
		public static void Normal()
		{
			Console.WriteLine("██ █╬█ ███ ███ ███ ██ ███ ╬╬ ███ █╬╬█ ██" +
"\n█╬ █▄█ █▄█ █▄█ ╬█╬ █▄ █▄╬ ╬╬ █╬█ ██▄█ █▄" +
"\n██ █╬█ █╬█ █╬╬ ╬█╬ █▄ █╬█ ╬╬ █▄█ █╬██ █▄");

			Program.Return();

			Console.WriteLine("Billy has taken your water bottle for a refill" +
				"\nand carelessly left your door askew.");
			Console.WriteLine("Now is your chance to make your move!\n");
			Console.WriteLine("You see a pair of pants hanging from the top drawer." +
				"\nIf you scale down them you should be able to drop to the floor safely." +
				"\nThe only other option is to jump from the dresser and hope you" +
				"\nland on a pillow below. " +
				"\nWhat do you choose?" +
				"\n1. Pants" +
				"\n2. Jump");
			var choice = Console.ReadLine().ToLower();
			Console.Clear();

			switch (choice)
			{
				case "1":
				case "pants":
				case "1.":
					{
						Console.WriteLine("You climb quietly from your cage and look over the edge of the dresser.");
						Console.WriteLine("You can see the leg of the pants hanging down, ");
						Console.WriteLine("so you lean over the edge to grab on with your paw.");
						Console.WriteLine("You shift forward and roll off of the dresser.");
						Console.WriteLine("For a moment, your paw slips and you think you may fall," +
							"\nbut you dig in with all four paws and regain your control" +
							"\nbefore scurrying down to the ground.");
						Program.Return();
						ChapterTwo.Normal();
						break;
					}

				case "2":
				case "jump":
				case "2.":
					{
						Console.WriteLine("You climb quietly from your cate and look over the edge of the dresser." +
							"\nSuddenly your home seems much further from the ground than you remembered." +
							"\nThe pillow lies a little bit further from the dresser than you would like." +
							"\nYou crouch down and brace for the jump, then launch off into a free fall." +
							"\nIt lasts only a few seconds, but you feel like time slows around you." +
							"\nThe ground becomes ever closer, and you wonder if you've made your last mistake." +
							"\nBut alas! You feel your body land sofly in the center of the pillow.");
						Program.Return();
						ChapterTwo.Normal();
						break;
					}
				default:
					{

						Console.WriteLine("Command is invalid...");
						Console.WriteLine("Press 'Enter' to retry.");
						Console.ReadLine();
						Normal();
						break;
					}
			}
		}

		public static void Hard()
		{
			Console.WriteLine("██ █╬█ ███ ███ ███ ██ ███ ╬╬ ███ █╬╬█ ██" +
"\n█╬ █▄█ █▄█ █▄█ ╬█╬ █▄ █▄╬ ╬╬ █╬█ ██▄█ █▄" +
"\n██ █╬█ █╬█ █╬╬ ╬█╬ █▄ █╬█ ╬╬ █▄█ █╬██ █▄");

			Program.Return();

			Console.WriteLine("Billy has taken your water bottle for a refill" +
				"\nand carelessly left your door askew.");
			Console.WriteLine("Now is your chance to make your move!\n");
			Console.WriteLine("You see a pair of pants hanging from the top drawer." +
				"\nIf you scale down them you should be able to drop to the floor safely." +
				"\nThe only other option is to jump from the dresser and hope you" +
				"\nland on a pillow below. " +
				"\nWhat do you choose?" +
				"\n1. Pants" +
				"\n2. Jump");
			var choice = Console.ReadLine().ToLower();
			Console.Clear();

			switch (choice)
			{
				case "1":
				case "pants":
				case "1.":
					{
						Console.WriteLine("You climb quietly from your cage and look over the edge of the dresser.");
						Console.WriteLine("You can see the leg of the pants hanging down, ");
						Console.WriteLine("so you lean over the edge to grab on with your paw.");
						Console.WriteLine("You shift forward and roll off of the dresser.");
						Console.WriteLine("For a moment, your paw slips and you think you may fall," +
							"\nbut you dig in with all four paws and regain your control" +
							"\nbefore scurrying down to the ground.");
						Program.Return();
						ChapterTwo.Hard();
						break;
					}

				case "2":
				case "jump":
				case "2.":
					{
						Console.WriteLine("You climb quietly from your cate and look over the edge of the dresser." +
							"\nSuddenly your home seems much further from the ground than you remembered." +
							"\nThe pillow lies a little bit further from the dresser than you would like." +
							"\nYou crouch down and brace for the jump, then launch off into a free fall." +
							"\nIt lasts only a few seconds, but you feel like time slows around you." +
							"\nThe ground becomes ever closer, and you wonder if you've made your last mistake." +
							"\nBut alas! You feel your body land sofly in the center of the pillow.");
						Program.Return();
						ChapterTwo.Hard();
						break;
					}
				default:
					{

						Console.WriteLine("Command is invalid...");
						Console.WriteLine("Press 'Enter' to retry.");
						Console.ReadLine();
						Hard();
						break;
					}
			}
		}

		
	}
}

