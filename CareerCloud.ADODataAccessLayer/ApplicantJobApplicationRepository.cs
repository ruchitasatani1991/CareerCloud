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
    public class ApplicantJobApplicationRepository : BaseADO, IDataRepository<ApplicantJobApplicationPoco>
    {
        public void Add(params ApplicantJobApplicationPoco[] items)
        {
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                foreach (ApplicantJobApplicationPoco poco in items)
                {

                    cmd.CommandText = @"INSERT INTO [JOB_PORTAL_DB].[dbo].[Applicant_Job_Applications]
                                       ([Id],[Applicant],[Job],[Application_Date])                                       
                                    VALUES
                                       (@Id,@Applicant,@Job,@Application_Date)";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    cmd.Parameters.AddWithValue("@Job", poco.Job);
                    cmd.Parameters.AddWithValue("@Application_Date", poco.ApplicationDate);
                   

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

        public IList<ApplicantJobApplicationPoco> GetAll(params Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
            ApplicantJobApplicationPoco[] pocos = new ApplicantJobApplicationPoco[500];
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand("select * from [JOB_PORTAL_DB].[dbo].[Applicant_Job_Applications]", con);

                int position = 0;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ApplicantJobApplicationPoco poco = new ApplicantJobApplicationPoco();

                    poco.Id = reader.GetGuid(0);

                    poco.Applicant = reader.GetGuid(1);

                    poco.Job = reader.GetGuid(2);                    

                    poco.ApplicationDate = reader.GetDateTime(3); 

                    poco.TimeStamp = (byte[])reader[4];

                    pocos[position] = poco;

                    position++;

                }
                con.Close();
            }
            return pocos.Where(a => a != null).ToList();
        }

        public IList<ApplicantJobApplicationPoco> GetList(Expression<Func<ApplicantJobApplicationPoco, bool>> where, params Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantJobApplicationPoco GetSingle(Expression<Func<ApplicantJobApplicationPoco, bool>> where, params Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
            IQueryable<ApplicantJobApplicationPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params ApplicantJobApplicationPoco[] items)
        {
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                foreach (ApplicantJobApplicationPoco poco in items)
                {

                    cmd.CommandText = @"DELETE FROM  [JOB_PORTAL_DB].[dbo].[Applicant_Job_Applications]
                                        where [Id]=@Id";


                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    con.Open();
                    int rowaffect = cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
        }

        public void Update(params ApplicantJobApplicationPoco[] items)
        {
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                foreach (ApplicantJobApplicationPoco poco in items)
                {

                    cmd.CommandText = @"UPDATE  [JOB_PORTAL_DB].[dbo].[Applicant_Job_Applications]
                                        SET [Applicant]=@Applicant,[Job]=@Job,
                                        [Application_Date]=@Application_Date
                                        where [Id]=@Id";




                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    cmd.Parameters.AddWithValue("@Job", poco.Job);
                    cmd.Parameters.AddWithValue("@Application_Date", poco.ApplicationDate);
                    
                    con.Open();
                    int rowaffect = cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
        }
    }
}
