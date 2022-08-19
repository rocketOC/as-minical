using RocketOC.MinicalDotnet;

//only accept piped-input for now
if (!Console.IsInputRedirected)
    return 0;

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

Console.WriteLine();

var mini = new Minical();
mini.PrintActivity(activity, 2, true);

return 0;