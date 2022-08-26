// See https://aka.ms/new-console-template for more information
Console.WriteLine("--------------------------");
Console.WriteLine("Let's play Build Libs!");
Console.WriteLine("--------------------------");
Console.Write("Enter a name:");
var name = Console.ReadLine();
Console.Write("Enter an adjective:");
var adjective1 = Console.ReadLine();
Console.Write("Enter a noun:");
var noun1 = Console.ReadLine();
Console.Write("Enter an adjective:");
var adjective2 = Console.ReadLine();
Console.Write("Enter a food (plural):");
var food = Console.ReadLine();
Console.Write("Enter a noun (plural):");
var noun2 = Console.ReadLine();
Console.Write("Enter a verb (ending in 'ed'):");
var verb = Console.ReadLine();
Console.Write("Enter a liquid:");
var liquid = Console.ReadLine();
Console.Write("Enter a noun:");
var noun3 = Console.ReadLine();

Console.WriteLine($"Come on over to {name}'s Pizza Parlor where you can enjoy your favorite {adjective1}-dish pizzas. You can try our famous {noun1}-lovers pizza, or select from our list of {adjective2} toppings, including sauteed {food}, {noun2}, and many more. Our crusts are hand-{verb} and basted in {liquid} to make them seem more {noun3}-made.");
Console.WriteLine("");
Console.WriteLine("Press any key to continue.");
Console.ReadLine();