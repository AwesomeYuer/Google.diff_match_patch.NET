using Google.DiffMatchPatch;

// Create a new diff-match-patch object
var dmp = new diff_match_patch();

var one = """
That is the new string!
This is the old string
""";
var two = """
This is the old string
That is the new string!
""";

// Compare the two strings and get a list of diffs
var diffs = dmp
                .diff_main
                        (
                            one
                            , two
                            , true
                        );
// Iterate through the list of diffs and print out the details
var i = 0;
foreach (var diff in diffs)
{
    i++;
    Console.WriteLine($"{i}:\r\n{diff.operation}: {diff.text}");
}

var patches = dmp.patch_make(one, two);
i = 0;
foreach (var patch in patches)
{
    i++;
    Console.WriteLine($"{i}:\r\n{patch}");
}
