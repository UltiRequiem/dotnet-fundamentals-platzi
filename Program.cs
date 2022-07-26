using Humanizer;

Console.WriteLine("Your name:");

var name = Console.ReadLine() ?? String.Empty;

Console.WriteLine("Your job:");

var job = Console.ReadLine() ?? String.Empty;

Console.WriteLine("Your age:");

var age = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

var message = $"My name is {name}, I'm {age.ToWords()} years old and I work as a {job}.";

Console.WriteLine(message);

Console.WriteLine($">> {DateTime.Now.ToOrdinalWords()}");

var secondMessage = $"We are in the day {DateTime.Now.Day.ToWords()} of the month {DateTime.Now.Month.ToWords()} of the year {DateTime.Now.Year.ToWords()}.";

Console.WriteLine(secondMessage);
