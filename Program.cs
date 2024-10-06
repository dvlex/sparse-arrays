// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

List<string> strings = ["ab", "ab", "abc"];
List<string> queries = ["ab", "abc", "bc"];

List<int> result = Result.matchingStrings(strings, queries);

// Console.WriteLine(strings.Where(x=>x=="ab").Count());

result.ForEach(x => Console.WriteLine(x));

class Result
{

    /*
     * Complete the 'matchingStrings' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY strings
     *  2. STRING_ARRAY queries
     */

    public static List<int> matchingStrings(List<string> strings, List<string> queries)
    {
        List<int> result = new List<int>();

        queries.ForEach(x => result.Add(strings.Where(y => y==x).Count()));

        return  result;
    }

}