using System.Data.SqlClient;

public class AuthService
{
    private DatabaseConnection database = new DatabaseConnection();

    public bool Login(string username, string password)
    {
        using (SqlConnection conn = database.GetConnection())
        {
            string query =
                "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            conn.Open();

            int result = (int)cmd.ExecuteScalar();

            return result > 0;
        }
    }
}