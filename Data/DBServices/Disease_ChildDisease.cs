using System.Data;
using System.Data.SqlClient;
using Clever.Kindergarten.Data.AbstractionModels;
using Clever.Kindergarten.Data.ConnectionDB;
using Clever.Kindergarten.Data.Models;

namespace Clever.Kindergarten.Data.DBServices
{
    public class ChildDiseaseServices : AppConnectionBase, CleverOperations<ChildDisease>
    {
        public void Add(ChildDisease model)
        {
            throw new NotImplementedException();
        }

        public void Delete(ChildDisease model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ChildDisease> GetAllData()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ChildDisease> GetAllDataByDiseaseId(int id)
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
                cmd = new SqlCommand($"SELECT ChildID,DiseaseID FROM ChildDisease where DiseaseID = {id}",con);            
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                IList<ChildDisease> diseases = new List<ChildDisease>() ;
                ChildDisease disease ;
                
                foreach (DataRow dr in dt.Rows)
                {
                    disease = new ChildDisease{ ChildID = Convert.ToInt32(dr[0]),DiseaseID = Convert.ToInt32(dr[1])};
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

        public IEnumerable<ChildDisease> GetAllDataByChildId(int id)
        {
            throw new NotImplementedException();
        }

        public ChildDisease GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ChildDisease model)
        {
            throw new NotImplementedException();
        }
    }
}