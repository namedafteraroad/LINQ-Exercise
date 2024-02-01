using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>() { "Portal", "Rust", "Turok", "Fallout", "Bioshock", "Borderlands", "DOOM", "Factorio", "Satisfactory", "Firewatch", "Outer Wilds", "Subnautica" };
            //Order the list of games by the length of the game name.
            //Remember to use LINQ which involves using a lambda expression.


           var gameNameLength =  games.OrderBy(w => w.Length);

            foreach (var game in gameNameLength)
            {
                Console.WriteLine(game);
            }
        }
    }
}
//Create a list of type string.************************DONE
//Populate the list with video game names.*******************DONE
//Alternatively, you can choose a different category of items if you prefer. ex. list of baseball teams, list of movie titles, etc.
//Order the list of games by the length of the game name.
//Remember to use LINQ which involves using a lambda expression.
//Use the list of common LINQ methods on the lecture page for help on deciding which method(s) to use:
//Linq Methods
//Use Method Syntax for this exercise.
//Stage, Commit, and Push your work to Github.