using System.Data;
using System.Data.SqlClient;
using Clever.Kindergarten.Data.AbstractionModels;
using Clever.Kindergarten.Data.ConnectionDB;
using Clever.Kindergarten.Data.Models;

namespace Clever.Kindergarten.Data.DBServices
{
    class HobbyServices : AppConnectionBase,IDBOperations<Hobby>
    {
        public void Add(Hobby model)
        {
            throw new NotImplementedException();
        }

        public void Delete(Hobby model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Hobby>? GetAllData()
        {
        
        if (con.State == System.Data.ConnectionState.Open)
        {
            con.Close();
        }
        
        try
        {
            SqlCommand cmd ;
            DataSet ds = new DataSet();
            con.Open();
            cmd = new SqlCommand("SELECT Id,Name,isAccessible FROM dbo.Hobbies",con);            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            IList<Hobby> hobbies = new List<Hobby>() ;
            Hobby hobby ;
            
            foreach (DataRow dr in dt.Rows)
            {
                hobby = new Hobby{ Id = Convert.ToInt32(dr[0]) , Name = Convert.ToString(dr[1]) ?? "Null",isAccessible = Convert.ToBoolean(dr[2])  };
                hobbies.Add(hobby);
            }
            
            return hobbies;
                      
        }
        catch (System.Exception e) 
        {            
            return null;
        }
        finally{
            con.Close();
        }   
        }

        public Hobby GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Hobby model)
        {
            throw new NotImplementedException();
        }
    }
}