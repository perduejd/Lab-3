using QueryBuilderStarter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryBuilder;

namespace QueryBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var queryBuilder = new QueryBuilderr(@"C:\Users\12766\source\repos\QueryBuilder\QueryBuilder\Data\data.db"); // file path
            SQLitePCL.Batteries.Init();


            Console.WriteLine("\nDelete records from table..."); // Deleting everything from the table
            queryBuilder.DeleteAll<Pokemon>();
            Console.WriteLine("\nAll Pokemon records deleted!");

            Console.WriteLine("\nDeleting records in banned game table...");
            queryBuilder.DeleteAll<BannedGame>();
            Console.WriteLine("\nAll Banned games deleted!");


            List<Pokemon> allPokemon = File.ReadAllLines(@"C:\Users\12766\source\repos\QueryBuilder\QueryBuilder\Data\AllPokemon.csv")
             .Select(v => Pokemon.FromFile(v))
             .ToList(); // Pokemon csv file path



            foreach (Pokemon pokemon in allPokemon)
            {
                queryBuilder.Create(pokemon);
                Console.WriteLine(pokemon.Id + " " + pokemon.Name + " was inserted.");
            }

            Console.WriteLine("\nPokemon is inputted!");



            // Banned games
            List<BannedGame> allBannedGames = File
            .ReadAllLines(@"C:\Users\12766\source\repos\QueryBuilder\QueryBuilder\Data\BannedGames.csv") // Banned Games csv file path
            .Select(line => BannedGame.FromFile(line))
            .ToList();

            foreach (BannedGame bannedGame in allBannedGames)
            {
                queryBuilder.Create(bannedGame);
                Console.WriteLine(bannedGame.Title + " was inserted.");

            }
            Console.WriteLine("\nBanned games inserted from CSV");
            Console.WriteLine("\nBanned games are inputted!");



            Pokemon pokemon1 = new Pokemon // Tests
            {
                Id = 1,
                DexNumber = 1,
                Name = "Testing",
                Form = "Test",
                Type1 = "Test",
                Type2 = "Test",
                HP = 99,
                Attack = 50,
                Defense = 1,
                SpecialAttack = 1,
                SpecialDefense = 1,
                Speed = 1,
                Generation = 1,

            };

            queryBuilder.Create(pokemon1);
            Console.WriteLine(pokemon1.Name + " has been added!"); // Testing to see if it works

            BannedGame bannedgame1 = new BannedGame
            {
                Id = 1,
                Title = "Jake",
                Series = "Star Wars",
                Country = "United States",
                Details = "This is a test."
            };
            queryBuilder.Create(bannedgame1);

            Console.WriteLine(bannedgame1.Title + " Has been added!"); // Testing banned game to see if it works

            queryBuilder.Dispose();
        }

    }
}