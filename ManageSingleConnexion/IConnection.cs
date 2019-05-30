using System.Data;

namespace ManageSingleConnection
{
    internal interface IConnection
    {
        IDbConnection Initialise(Connection connection, ConnectionType connectionType);
    }
}
