namespace SampleNuGet.Tests.Tests;

public class SerializationTest
{
    /// <summary>
    /// we want to test if serialization work
    /// </summary>
    [Fact]
    public void SerializeTest1()
    {
        var objectTest = Tuple.Create(1, "", new List<object>(), 1.5f);
        var serialized = Utils.SerializeUtil.SerializeObject(objectTest);
        var unserialized = Utils.SerializeUtil.DeserializeObject<Tuple<int, string, List<object>, float>>(serialized);
        var b = EqualsTuples(objectTest, unserialized);
        Assert.True(b);
    }

    /// <summary>
    /// Compare if two tuples are equal
    /// </summary>
    /// <param name="t1">t1</param>
    /// <param name="t2">t2</param>
    /// <returns>true if equal</returns>
    private static bool EqualsTuples(Tuple<int, string, List<object>, float>? t1, Tuple<int, string, List<object>, float>? t2)
    {
        if (t1 == null && t2 == null)
            return true;
        if (t1 == null || t2 == null)
            return false;
        
        return t1.Item1.Equals(t2.Item1) &&
               t1.Item2.Equals(t2.Item2) && 
               EqualsLists(t1.Item3, t2.Item3) &&
               t1.Item4.Equals(t2.Item4);
    }

    /// <summary>
    /// Compare if two lists are equal
    /// </summary>
    /// <param name="t1">first list</param>
    /// <param name="t2">second list</param>
    /// <returns>true if equal</returns>
    private static bool EqualsLists(IReadOnlyList<object> t1, IReadOnlyList<object> t2)
    {
        if (t1.Count != t2.Count)
            return false;
        
        for (var index = 0; index < t1.Count; index++)
        {
            var v1 = t1[index];
            var v2 = t2[index];

            if (v1.Equals(v2) == false)
                return false;
        }

        return true;
    }
}