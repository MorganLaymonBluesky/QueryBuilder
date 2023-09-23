using QueryBuilder;
using QueryBuilder.Models;
using System.ComponentModel.DataAnnotations;
namespace QueryBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            var dbPath = root + "\\Data\\data.db";
            QueryBuilder query = new QueryBuilder(dbPath);
            List<BannedGame> banGms = new List<BannedGame>();
            List<Pokemon> pokes = new List<Pokemon>();

            using (query)
            {
                Console.WriteLine("Welcome to Morgan's QueryBuilder!\n" +
                                  "---------------------------------\n");
                Console.WriteLine("We will now clear the 'Pokemon' and 'BannedGame' Table.\n");
                query.DeleteAll(new Pokemon());
                Console.WriteLine("SUCCESS: 'Pokemon' Table Cleared.");
                query.DeleteAll(new BannedGame());
                Console.WriteLine("SUCCESS: 'BannedGame' Table Cleared.\n");
                Console.WriteLine("---------------------------------\n" +
                              "\nWe will now repopulate the tables using the CSV files provided by Will.\n");
                csvInsert("AllPokemon.csv");
                csvInsert("BannedGames.csv");
                foreach (var pokemon in pokes)
                {
                    query.Create(pokemon);
                }
                Console.WriteLine("SUCCESS: 'Pokemon' Table Repopulated.");
                foreach (var banGm in banGms)
                {
                    query.Create(banGm);
                }
                Console.WriteLine("SUCCESS: 'BannedGame' Table Repopulated.\n");
                Console.WriteLine("---------------------------------\n" +
                              "\nWe will now insert singular items into the database: \n");
                query.Create(new Pokemon(900, "Morgan", "Male", "Water", "Fire", 100, 100, 100, 100, 100, 100, 100, 1));
                query.Create(new BannedGame("The Worst Game Ever", "The Worst", "USA", "No Details"));
                Console.WriteLine("SUCCESS: Items added to database.");
            }

            void csvInsert(string fileName)
            {
                using (StreamReader newReader = new StreamReader(root + "\\Data\\" + fileName))
                {
                    List<string> lines = new List<string>();
                    while (!newReader.EndOfStream)
                    {
                        lines.Add(newReader.ReadLine());
                    }
                    for (int i = 0; i < lines.Count; i++)
                    {
                        string nextItem = lines[i];
                        string[] itemProperties = nextItem.Split(',');

                        if (fileName == "AllPokemon.csv")
                        {
                            Pokemon poke = new Pokemon(Convert.ToInt32(itemProperties[0]), itemProperties[1], itemProperties[2], itemProperties[3], itemProperties[4], Convert.ToInt32(itemProperties[5]), Convert.ToInt32(itemProperties[6]), Convert.ToInt32(itemProperties[7]), Convert.ToInt32(itemProperties[8]), Convert.ToInt32(itemProperties[9]), Convert.ToInt32(itemProperties[10]), Convert.ToInt32(itemProperties[11]), Convert.ToInt32(itemProperties[12]));
                            pokes.Add(poke);
                        }
                        else if (fileName == "BannedGames.csv")
                        {
                            BannedGame banGa = new BannedGame(itemProperties[0], itemProperties[1], itemProperties[2], itemProperties[3]);
                            banGms.Add(banGa);
                        }
                    }
                    newReader.Close();
                }
            }
        }
    }
}