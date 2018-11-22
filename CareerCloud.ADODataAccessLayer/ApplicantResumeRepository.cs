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
    public class ApplicantResumeRepository : BaseADO, IDataRepository<ApplicantResumePoco>
    {
        public void Add(params ApplicantResumePoco[] items)
        {
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                foreach (ApplicantResumePoco poco in items)
                {

                    cmd.CommandText = @"INSERT INTO [JOB_PORTAL_DB].[dbo].[Applicant_Resumes]
                                       ([Id],[Applicant],[Resume],[Last_Updated])
                                    VALUES
                                       (@Id,@Applicant,@Resume,@Last_Updated)";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    cmd.Parameters.AddWithValue("@Resume", poco.Resume);
                    cmd.Parameters.AddWithValue("@Last_Updated", poco.LastUpdated);
                   

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

        public IList<ApplicantResumePoco> GetAll(params Expression<Func<ApplicantResumePoco, object>>[] navigationProperties)
        {
            ApplicantResumePoco[] pocos = new ApplicantResumePoco[500];
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand("select * from [JOB_PORTAL_DB].[dbo].[Applicant_Resumes]", con);

                int position = 0;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ApplicantResumePoco poco = new ApplicantResumePoco();

                    poco.Id = reader.GetGuid(0);
                    poco.Applicant = reader.GetGuid(1);
                    poco.Resume = reader.GetString(2);                    
                    if (!reader.IsDBNull(3))
                    {
                        poco.LastUpdated = reader.GetDateTime(3);
                    }
                    else
                    {
                        poco.LastUpdated = null;
                    }

                    pocos[position] = poco;

                    position++;

                }
                con.Close();
            }
            return pocos.Where(a => a != null).ToList();
        }

        public IList<ApplicantResumePoco> GetList(Expression<Func<ApplicantResumePoco, bool>> where, params Expression<Func<ApplicantResumePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantResumePoco GetSingle(Expression<Func<ApplicantResumePoco, bool>> where, params Expression<Func<ApplicantResumePoco, object>>[] navigationProperties)
        {
            IQueryable<ApplicantResumePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params ApplicantResumePoco[] items)
        {
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                foreach (ApplicantResumePoco poco in items)
                {

                    cmd.CommandText = @"DELETE FROM  [JOB_PORTAL_DB].[dbo].[Applicant_Resumes]
                                        where [Id]=@Id";


                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    con.Open();
                    int rowaffect = cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
        }

        public void Update(params ApplicantResumePoco[] items)
        {
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                foreach (ApplicantResumePoco poco in items)
                {

                    cmd.CommandText = @"UPDATE  [JOB_PORTAL_DB].[dbo].[Applicant_Resumes]
                                        SET [Applicant]=@Applicant,[Resume]=@Resume,
                                        [Last_Updated]=@Last_Updated                                       
                                        where [Id]=@Id";




                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    cmd.Parameters.AddWithValue("@Resume", poco.Resume);
                    cmd.Parameters.AddWithValue("@Last_Updated", poco.LastUpdated);
                   
                    con.Open();
                    int rowaffect = cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
        }
    }
}
