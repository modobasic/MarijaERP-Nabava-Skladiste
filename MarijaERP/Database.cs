using Microsoft.Data.SqlClient;
using System.Data;

namespace MarijaERP
{
    public static class Database
    {
        private static string connectionString =
            @"Server=localhost;Database=MarijaERP;Trusted_Connection=True;TrustServerCertificate=True;";

        public static DataTable GetData(string query)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            using SqlCommand command = new SqlCommand(query, connection);
            using SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public static void Execute(string query)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            using SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}