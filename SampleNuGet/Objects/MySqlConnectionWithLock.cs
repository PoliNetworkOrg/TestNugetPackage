#region

using JetBrains.Annotations;
using MySql.Data.MySqlClient;

#endregion

namespace SampleNuGet.Objects;

[PublicAPI]
public class MySqlConnectionWithLock
{
    public readonly MySqlConnection Conn;
    public readonly object Lock;

    public MySqlConnectionWithLock(string getConnectionString)
    {
        Conn = new MySqlConnection(getConnectionString);
        Lock = new object();
    }
}