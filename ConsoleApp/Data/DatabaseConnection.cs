using System.Data.SqlClient;

public class DatabaseConnection
{
    private string connectionString =
        "Server=localhost;Database=SafeVault;Trusted_Connection=True;";

    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}