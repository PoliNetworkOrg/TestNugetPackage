#region

using MySql.Data.MySqlClient;

#endregion

namespace SampleNuGet.Objects;

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