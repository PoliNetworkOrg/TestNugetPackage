#region

using Newtonsoft.Json.Linq;

#endregion

namespace SampleNuGet.Objects;

public class ExceptionNumbered : Exception
{
    private const int DefaultV = 1;
    private int _v;

    public ExceptionNumbered(Exception? item1, int v = DefaultV) : base(item1?.Message, item1)
    {
        _v = v;
    }

    public ExceptionNumbered(string message, int v = DefaultV) : base(message)
    {
        _v = v;
    }

    internal void Increment()
    {
        _v++;
    }


    internal bool AreTheySimilar(Exception? item2)
    {
        return Message == item2?.Message;
    }

    public int GetNumberOfTimes()
    {
        return _v;
    }

    private static JObject GetStackTrace(string? stackTracePar)
    {
        var result = new JObject
        {
            ["eStack"] = stackTracePar,
            ["currStack"] = Environment.StackTrace
        };
        return result;
    }
}