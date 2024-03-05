List<Dictionary<string, string>> inputList = new List<Dictionary<string, string>>()
        {
            new Dictionary<string, string> { {"V", "S001"} },
            new Dictionary<string, string> { {"V", "S002"} },
            new Dictionary<string, string> { {"VI", "S001"} },
            new Dictionary<string, string> { {"VI", "S005"} },
            new Dictionary<string, string> { {"VII", "S005"} },
            new Dictionary<string, string> { {"V", "S009"} },
            new Dictionary<string, string> { {"VIII", "S007"} }
        };

HashSet<string> uniqueValues = GetUniqueValues(inputList);

Console.WriteLine("UniqueValues: {" + string.Join(", ", uniqueValues) + "}");

static HashSet<string> GetUniqueValues(List<Dictionary<string, string>> inputList)
{
    HashSet<string> uniqueValues = new HashSet<string>();

    foreach (var dictionary in inputList)
    {
        foreach (var value in dictionary.Values)
        {
            uniqueValues.Add(value);
        }
    }

    return uniqueValues;
}
