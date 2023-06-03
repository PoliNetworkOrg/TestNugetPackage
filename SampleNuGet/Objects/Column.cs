using JetBrains.Annotations;

namespace SampleNuGet.Objects;

[PublicAPI]
public class Column
{
    public readonly Type DataType;
    public readonly string Name;

    public Column(string name, Type dataType)
    {
        Name = name;
        DataType = dataType;
    }
}