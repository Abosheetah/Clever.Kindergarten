using System.Data.SqlClient;

namespace Clever.Kindergarten.Data.ConnectionDB
{
    public class AppConnectionBase 
    {
        public SqlConnection con = new SqlConnection(); 

        public AppConnectionBase(){
            con.ConnectionString = $"Data Source=.\\SQLEXPRESS;Initial Catalog=Clever.ChildCustodyDB;Integrated Security=True";
        }

    }
}