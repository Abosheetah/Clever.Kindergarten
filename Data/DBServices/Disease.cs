using System.Data;
using System.Data.SqlClient;
using Clever.Kindergarten.Data.AbstractionModels;
using Clever.Kindergarten.Data.ConnectionDB;
using Clever.Kindergarten.Data.Models;

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
                con.Open();
                cmd = new SqlCommand($"Insert Into Diseases (Name,EatForbidden,Description) values (N'{model.Name}',N'{model.EatForbidden}',N'{model.Description}')",con);            

                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("The Data Saved!");
                }
                else
                {
                    Console.WriteLine("The Data Do Not Saved!");
                }
                
                        
            }
            catch (System.Exception e) 
            {            
                Console.WriteLine($"The Data Do Not Saved! , {e.Message}");
            }
            finally{
                con.Close();
            }  
        }

        public void Delete(Disease model)
        {
            //this model is related with childDisease.
            //must show message to user to show count of children with this disease. 
            //if the user delete this disease we delete all children with this disease.

            //get count of children with this disease.
            ChildDiseaseServices childDiseaseServices = new ChildDiseaseServices();

            IEnumerable<ChildDisease> diseases = childDiseaseServices.GetAllDataByDiseaseId(model.Id);                       
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
            Disease disease = new Disease();
        if (con.State == System.Data.ConnectionState.Open)
        {
            con.Close();
        }
        
        try
            {
                SqlCommand cmd ;
                DataSet ds = new DataSet();
                con.Open();
                cmd = new SqlCommand($"SELECT ID,Name,EatForbidden,Description FROM Diseases Where Id = {id}",con);            
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);                
                
                
                foreach (DataRow dr in dt.Rows)
                {
                    disease = new Disease{ Id = Convert.ToInt32(dr[0]) , Name = Convert.ToString(dr[1]) ?? "Null"
                    , EatForbidden = Convert.ToString(dr[2]) , Description = Convert.ToString(dr[3])  };                    
                }
                
                return disease;
                        
            }
            catch (System.Exception e) 
            {            
                return null;
            }
            finally{
                con.Close();
            }   
        }

        public void Update(Disease model)
        {
                  
        if (con.State == System.Data.ConnectionState.Open)
        {
            con.Close();
        }
        
        try
            {
                SqlCommand cmd ;                
                con.Open();
                cmd = new SqlCommand($"Update Diseases SET Name = N'{model.Name}' ,EatForbidden = N'{model.EatForbidden}' ,Description = N'{model.Description}' Where Id = N'{model.Id}'",con);            

                if (cmd.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("The Data Updated!");
                }
                else
                {
                    Console.WriteLine("The Data Do Not Update!");
                }
                
                        
            }
            catch (System.Exception e) 
            {            
                Console.WriteLine($"The Data Do Not Update! , {e.Message}");
            }
            finally{
                con.Close();
            }
        }
    }
}