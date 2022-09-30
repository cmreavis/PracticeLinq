using System.Linq;

List<string> vidyaGames = new()
{
    "Fallout",
    "Call of Duty",
    "Overwatch",
    "Bloons",
    "Halo",
    "Elden Ring",
    "Rocket League"
};
//sorting method with Linq, lambda operator, & method syntax
vidyaGames = vidyaGames.OrderBy(x => x.Length).ToList();

//foreach loop to print out each string beginning with shortest string

/* for future reference, was stuck trying to simply print the list -
you MUST iterate through the items, simple concept but easy to forget I guess! */

foreach (string item in vidyaGames)
Console.WriteLine(item);


