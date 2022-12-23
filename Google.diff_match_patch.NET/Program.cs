using DiffMatchPatch;

// Create a new diff-match-patch object
var dmp = new diff_match_patch();

// Compare the two strings and get a list of diffs
var diffs = dmp
                .diff_main
                        (
                            "This is the old string"
                            , "That is the new string!"
                        );

// Iterate through the list of diffs and print out the details
foreach (var diff in diffs)
{
    if (diff.operation == Operation.INSERT)
    {
        Console.WriteLine("Insert: " + diff.text);
    }
    else if (diff.operation == Operation.DELETE)
    {
        Console.WriteLine("Delete: " + diff.text);
    }
    else if (diff.operation == Operation.EQUAL)
    {
        Console.WriteLine("Equal: " + diff.text);
    }
}

