using System;
namespace Adventure
{
	public class GameOver
	{
        public static void End()
		{
			Console.Clear();
			Console.WriteLine("Thwarted again! Better luck next time.");
			Console.ReadLine();
			Console.Clear();
		}
}
}

