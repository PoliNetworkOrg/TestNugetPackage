namespace SampleNuGet.Objects;

public class Colonna
{
    public readonly Type DataType;
    public readonly string Name;

    public Colonna(string name, Type dataType)
    {
        Name = name;
        DataType = dataType;
    }
}