partial class Program
{
    private static void DeferredExecution(string[] names)
    {
        SectionTitle("Deferred execution");

        var query1 = names.Where(name => name.EndsWith("m"));
        var query2 = from name in names where name.EndsWith("m") select name;

        string[] result1 = query1.ToArray();
        List<string> result2 = query2.ToList();

        foreach (string name in query1)
        {
            WriteLine(name);
            // names[2] = "Jimmy";
        }
    }

    private static void FilteringUsingWhere(string[] names)
    {
        SectionTitle("Filtering entities using Where");

        // Explicitly creating the required delegate.
        // var query = names.Where(
        //   new Func<string, bool>(NameLongerThanFour));

        // The compiler creates the delegate automatically.
        // var query = names.Where(NameLongerThanFour);

        // Using a lambda expression instead of a named method.
        // IOrderedEnumerable<string> query = names
        //   .Where(name => name.Length > 4)
        //   .OrderBy(name => name.Length)
        //   .ThenBy(name => name);

        // foreach (string item in query)
        // {
        //     WriteLine(item);
        // }
    }
}