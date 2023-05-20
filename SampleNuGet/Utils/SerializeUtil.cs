using System.Text;
using Newtonsoft.Json;

namespace SampleNuGet.Utils;

//System.Runtime.Serialization.Formatters.Binary.BinaryFormatter is obsolete, replaced with
//https://stackoverflow.com/a/53078979


/// <summary>
/// Serialization util
/// </summary>
public static class SerializeUtil
{
    /// <summary>
    /// Serialize object
    /// </summary>
    /// <param name="value">object to serialize</param>
    /// <returns>byte array of serialized object</returns>
    public static byte[] SerializeObject(object? value) => Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(value));

    /// <summary>
    /// Deserialize object, given the type (T)
    /// </summary>
    /// <param name="bytes">byte array of the serialized object to deserialize</param>
    /// <typeparam name="T">type of the object</typeparam>
    /// <returns>the deserialized object</returns>
    public static T? DeserializeObject<T>(byte[] bytes)
    {
        var x = Encoding.UTF8.GetString(bytes);
        return JsonConvert.DeserializeObject<T>(x);
    }

    /// <summary>
    /// Get memory stream from byte array
    /// </summary>
    /// <param name="bytes">byte array</param>
    /// <returns>memory stream</returns>
    public static MemoryStream GetMemoryStreamFromByteArray(byte[] bytes)
    {
        return new MemoryStream(bytes);
    }
}