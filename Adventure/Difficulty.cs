using System;
namespace Adventure
{
    public class Difficulty
    {
        public static void Choice()
        {
            string choice;

            Console.WriteLine("Choose your difficulty:");
            Console.WriteLine("1. Beginner");
            Console.WriteLine("2. Normal");
            Console.WriteLine("3. Hard");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "beginner":
                case "1.":
                    {
                        ChapterOne.Beginner();
                        break;

                    }
                case "2":
                case "normal":
                case "2.":
                    {
                        ChapterOne.Normal();
                        break;
                    }
                case "3":
                case "build":
                case "build a shelter":
                    {
                        ChapterOne.Hard();
                        break;
                    }
                default:
                    {

                        Console.WriteLine("Command is invalid...");
                        Console.WriteLine("Press 'Enter' to retry.");
                        Console.ReadLine();
                        Choice();
                        break;
                    }
            }
        }
    }
}

