using Humanizer;

Console.WriteLine("Your name:");
var name = Console.ReadLine() ?? String.Empty;

Console.WriteLine("Your job:");
var job = Console.ReadLine() ?? String.Empty;

Console.WriteLine("Your age:");
var age = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException() );

Console.WriteLine($"My name is {name}, I'm {age.ToWords()} years old and I work as a {job}.");