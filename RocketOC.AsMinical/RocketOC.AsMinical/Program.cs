using RocketOC.MinicalDotnet;
using System.CommandLine;

//only accept piped input for now
if (!Console.IsInputRedirected)
    return 0;

//parse the input data
//may change to list in future so we can use frequency info for something
var activity = new HashSet<DateOnly>();
while (Console.In.Peek() != -1)
{
    string? input = Console.In.ReadLine();
    if (!string.IsNullOrWhiteSpace(input))
    {
        //dates in yyyy-MM-dd format work well
        var parsed = DateOnly.Parse(input);
        activity.Add(parsed);
    }
}

//setup parsing for the command line arguments
var rootCommand = new RootCommand("Make a mini calendar");

var wrap = new Option<int>
    (name: "--wrap",
    description: "Wrap to a new row after X months",
    getDefaultValue: () => -1);

var sep = new Option<int>
    (name: "--sep",
    description: "Separate the months by X blocks. O and 2 are nice",
    getDefaultValue: () => 0);

rootCommand.AddOption(wrap);
rootCommand.AddOption(sep);

rootCommand.SetHandler((wrapOptionValue, separtationOptionValue) =>
{
    Console.WriteLine();
    var mini = new Minical();
    mini.PrintActivity(activity, separtationOptionValue, true, wrapOptionValue);
}, wrap, sep);


//process the commands
await rootCommand.InvokeAsync(args);
return 0;