using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyJobDescriptionRepository : BaseADO, IDataRepository<CompanyJobDescriptionPoco>
    {
        public void Add(params CompanyJobDescriptionPoco[] items)
        {
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                foreach (CompanyJobDescriptionPoco poco in items)
                {

                    cmd.CommandText = @"INSERT INTO [JOB_PORTAL_DB].[dbo].[Company_Jobs_Descriptions]
                                       ([Id],[Job],[Job_Name],[Job_Descriptions])
                                    VALUES
                                       (@Id,@Job,@Job_Name,@Job_Descriptions)";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Job", poco.Job);
                    cmd.Parameters.AddWithValue("@Job_Name", poco.JobName);
                    cmd.Parameters.AddWithValue("@Job_Descriptions", poco.JobDescriptions);


                    con.Open();
                    int rowaffect = cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyJobDescriptionPoco> GetAll(params Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            CompanyJobDescriptionPoco[] pocos = new CompanyJobDescriptionPoco[1500];
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand("select * from [JOB_PORTAL_DB].[dbo].[Company_Jobs_Descriptions]", con);

                int position = 0;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    CompanyJobDescriptionPoco poco = new CompanyJobDescriptionPoco();

                    poco.Id = reader.GetGuid(0);
                    poco.Job = reader.GetGuid(1);
                    if (!reader.IsDBNull(2))
                    {
                        poco.JobName = reader.GetString(2);
                    }
                    else
                    {
                        poco.JobName = null;
                    }
                    if (!reader.IsDBNull(3))
                    {
                        poco.JobDescriptions = reader.GetString(3);
                    }
                    else
                    {
                        poco.JobDescriptions = null;
                    }
                    if (!reader.IsDBNull(4))
                    {
                        poco.TimeStamp = (byte[])reader[4];
                    }
                    else
                    {
                        poco.TimeStamp = null;
                    }




                    pocos[position] = poco;

                    position++;

                }
                con.Close();
            }
            return pocos.Where(a => a != null).ToList();
           
        }

        public IList<CompanyJobDescriptionPoco> GetList(Expression<Func<CompanyJobDescriptionPoco, bool>> where, params Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyJobDescriptionPoco GetSingle(Expression<Func<CompanyJobDescriptionPoco, bool>> where, params Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyJobDescriptionPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyJobDescriptionPoco[] items)
        {
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                foreach (CompanyJobDescriptionPoco poco in items)
                {

                    cmd.CommandText = @"DELETE FROM  [JOB_PORTAL_DB].[dbo].[Company_Jobs_Descriptions]
                                        where [Id]=@Id";


                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    con.Open();
                    int rowaffect = cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
        }

        public void Update(params CompanyJobDescriptionPoco[] items)
        {
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                foreach (CompanyJobDescriptionPoco poco in items)
                {

                    cmd.CommandText = @"UPDATE  [JOB_PORTAL_DB].[dbo].[Company_Jobs_Descriptions]
                                        SET [Job]=@Job,[Job_Name]=@Job_Name,
                                        [Job_Descriptions]=@Job_Descriptions
                                        where [Id]=@Id";




                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Job", poco.Job);
                    cmd.Parameters.AddWithValue("@Job_Name", poco.JobName);
                    cmd.Parameters.AddWithValue("@Job_Descriptions", poco.JobDescriptions);
                    
                    con.Open();
                    int rowaffect = cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
        }
    }
}
