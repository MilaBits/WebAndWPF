using Factory.Factories;
using Logic.Interfaces;
using System;
using Domain.Models;

namespace UIConsole
{
    class Program
    {
        public static ISongLogic songLogic = SongLogicFactory.GetSongLogic();
        public static IImageLogic imageLogic = ImageLogicFactory.GetImageLogic();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(); 
                Console.WriteLine("--- Media Manager ---");
                ConsoleKeyInfo pressedKey = ShowOptions();

                string search = string.Empty;
                switch (pressedKey.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.WriteLine();
                        Console.WriteLine("--- Songs Found ---");
                        foreach (Song song in songLogic.GetAllSongs())
                        {
                            Console.WriteLine(song);
                        }
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.WriteLine();
                        Console.WriteLine("--- Images Found ---");
                        foreach (Image image in imageLogic.GetAllImages())
                        {
                            Console.WriteLine(image);
                        }
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.WriteLine();
                        Console.Write("Search for songs containing: ");
                        search = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("--- Songs Found ---");
                        foreach (Song song in songLogic.SearchSongs(search))
                        {
                            Console.WriteLine(song);
                        }
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.WriteLine();
                        Console.Write("Search for images containing: ");
                        search = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("--- Images Found ---");
                        foreach (Image image in imageLogic.SearchImages(search))
                        {
                            Console.WriteLine(image);
                        }
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        private static ConsoleKeyInfo ShowOptions()
        {
            Console.WriteLine();
            Console.WriteLine("Options");
            Console.WriteLine("    1. List Songs");
            Console.WriteLine("    2. List Images");
            Console.WriteLine("    3. Search Songs");
            Console.WriteLine("    4. Search Images");
            Console.WriteLine("    5. Exit");
            Console.Write("Select action (1-5): ");

            ConsoleKeyInfo pressedKey = Console.ReadKey();
            Console.WriteLine();
            return pressedKey;
        }
    }
}
