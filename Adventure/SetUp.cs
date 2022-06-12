using System;
namespace Adventure
{
	public class SetUp
	{
		public static void GameSetUp()
        {
            Console.WriteLine("What would you like your character's name to be?");
            var charName = Console.ReadLine();
            Console.WriteLine($"Great! Your character is now named {charName}.");

            Console.Clear();

            Console.WriteLine("    ████████                      ████████    ");
            Console.WriteLine("  ██░░░░░░░░██                  ██░░░░░░░░██  ");
            Console.WriteLine("██░░████░░░░░░██              ██░░░░░░████░░██     Let the adventure begin!");
            Console.WriteLine("██░░░░░░██░░░░██████████████████░░░░██░░░░░░██");
            Console.WriteLine($"██░░░░░░██░░░░░░░░░░░░░░░░░░░░░░░░░░██░░░░░░██     You are a hamster named {charName}!");
            Console.WriteLine("██░░░░██░░░░░░░░░░░░░░░░░░░░░░░░      ██░░░░██     For weeks, you have lived a contented life");
            Console.WriteLine("  ████░░░░░░░░░░░░░░░░░░░░              ████       on the dresser of the young giant, Billy.");
            Console.WriteLine("    ██░░░░██████░░░░░░        ██████    ██    ");
            Console.WriteLine("    ██░░████    ██          ██    ████  ██         But Billy often leaves you and travels");
            Console.WriteLine("  ██░░░░████    ██          ██    ████    ██       to the land of Kichin, returning with piles of food");
            Console.WriteLine("  ██░░░░██  ██████          ██████  ██    ██       the likes of which you had previously only dreamt of.");
            Console.WriteLine("  ████    ██████              ██████    ████  ");
            Console.WriteLine("  ██                  ██                  ██       You have heard tales of Kichin from the other hamsters in Petstor,");
            Console.WriteLine("  ████                                  ████       and now you believe you are a short few days' quest from this land.");
            Console.WriteLine("  ██            ██    ██    ██            ██  ");
            Console.WriteLine("    ██            ████  ████            ██         Spoils unknown await you...");
            Console.WriteLine("    ██████░░                      ░░██████    ");
            Console.WriteLine("    ██░░░░░░  ██              ██  ░░░░░░██         If only you could get out of this cage!");
            Console.WriteLine("    ██░░░░  ░░░░██          ██░░░░  ░░░░██         You've managed it before, but have yet to get to Kichin without being caught.");
            Console.WriteLine("    ██░░  ██░░░░██          ██░░░░██  ░░██    ");
            Console.WriteLine("    ██      ████              ████      ██         As the giant eats his feast and stares at the lighted box,");
            Console.WriteLine("      ██                              ██           you begin to formulate your master plan.");
            Console.WriteLine("      ██                              ██      ");
            Console.WriteLine("    ██░░░░░░████              ████░░░░░░██    ");
            Console.WriteLine("    ████████    ██████████████    ████████         Tomorrow night... you escape!");

           

        }
	}
}

