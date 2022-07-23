using System.Data.SqlClient;

namespace Clever.Kindergarten.Data.ConnectionDB
{
    class AppConnectionBase 
    {
        public SqlConnection con = new SqlConnection(); 

        public AppConnectionBase(){
            con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Clever.KindergartenDB;Integrated Security=True";
        }

    }
}