using System.Data;
using System.Data.SqlClient;
using Clever.Kindergarten.Data.AbstractionModels;
using Clever.Kindergarten.Data.ConnectionDB;
using Clever.Kindergarten.Data.Models.Disease_;

namespace Clever.Kindergarten.Data.DBServices
{
    public class DiseaseServices : AppConnectionBase, CleverOperations<Disease>
    {
        public void Add(Disease model)
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
                cmd = new SqlCommand("Insert Into Diseases (Name,EatForbidden,Description)",con);            
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                IList<Disease> diseases = new List<Disease>() ;
                Disease disease ;
                
                foreach (DataRow dr in dt.Rows)
                {
                    disease = new Disease{ Id = Convert.ToInt32(dr[0]) , Name = Convert.ToString(dr[1]) ?? "Null"
                    , EatForbidden = Convert.ToString(dr[2]) , Description = Convert.ToString(dr[3])  };
                    diseases.Add(disease);
                }
                
                
                        
            }
            catch (System.Exception e) 
            {            
                
            }
            finally{
                con.Close();
            }  
        }

        public void Delete(Disease model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Disease> GetAllData()
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
                cmd = new SqlCommand("SELECT ID,Name,EatForbidden,Description FROM Diseases",con);            
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                IList<Disease> diseases = new List<Disease>() ;
                Disease disease ;
                
                foreach (DataRow dr in dt.Rows)
                {
                    disease = new Disease{ Id = Convert.ToInt32(dr[0]) , Name = Convert.ToString(dr[1]) ?? "Null"
                    , EatForbidden = Convert.ToString(dr[2]) , Description = Convert.ToString(dr[3])  };
                    diseases.Add(disease);
                }
                
                return diseases;
                        
            }
            catch (System.Exception e) 
            {            
                return null;
            }
            finally{
                con.Close();
            }   
        }

        public Disease GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Disease model)
        {
            throw new NotImplementedException();
        }
    }
}