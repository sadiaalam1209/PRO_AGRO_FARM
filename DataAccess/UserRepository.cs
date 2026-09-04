using Pro_Agro_farm.DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace Pro_Agro_farm.DataAccess
{
    public static class UserRepository
    {
        /// <summary>Checks the Users table for a matching Admin username/password.</summary>
        public static bool ValidateAdmin(string username, string password)
        {
            DataTable dt = DatabaseHelper.ExecuteQuery(
                "SELECT * FROM Users WHERE Username = @U AND Password = @P AND Role = 'Admin'",
                new SqlParameter("@U", username),
                new SqlParameter("@P", password));

            return dt.Rows.Count > 0;
        }
    }
}
