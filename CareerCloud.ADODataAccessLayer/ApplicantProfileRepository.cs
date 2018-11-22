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
    public class ApplicantProfileRepository : BaseADO, IDataRepository<ApplicantProfilePoco>
    {
        public void Add(params ApplicantProfilePoco[] items)
        {
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                foreach (ApplicantProfilePoco poco in items)
                {

                    cmd.CommandText = @"INSERT INTO [JOB_PORTAL_DB].[dbo].[Applicant_Profiles]
                                       ([Id],[Login],[Current_Salary],[Current_Rate],[Currency],
                                        [Country_Code],[State_Province_Code],[Street_Address],
                                        [City_Town],[Zip_Postal_Code])
                                    VALUES
                                       (@Id,@Login,@Current_Salary,@Current_Rate,@Currency
                                       ,@Country_Code,@State_Province_Code,@Street_Address
                                       ,@City_Town,@Zip_Postal_Code)";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Login", poco.Login);
                    cmd.Parameters.AddWithValue("@Current_Salary", poco.CurrentSalary);
                    cmd.Parameters.AddWithValue("@Current_Rate", poco.CurrentRate);
                    cmd.Parameters.AddWithValue("@Currency", poco.Currency);
                    cmd.Parameters.AddWithValue("@Country_Code", poco.Country);
                    cmd.Parameters.AddWithValue("@State_Province_Code", poco.Province);
                    cmd.Parameters.AddWithValue("@Street_Address", poco.Street);
                    cmd.Parameters.AddWithValue("@City_Town", poco.City);
                    cmd.Parameters.AddWithValue("@Zip_Postal_Code", poco.PostalCode);

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

        public IList<ApplicantProfilePoco> GetAll(params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            ApplicantProfilePoco[] pocos = new ApplicantProfilePoco[500];
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand("select * from [JOB_PORTAL_DB].[dbo].[Applicant_Profiles]", con);
                con.Open();
                int position = 0;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ApplicantProfilePoco poco = new ApplicantProfilePoco();

                    poco.Id = reader.GetGuid(0);
                    poco.Login = reader.GetGuid(1);
                    if (!reader.IsDBNull(2))
                    {
                        poco.CurrentSalary = reader.GetDecimal(2);
                    }
                    else
                    {
                        poco.CurrentSalary = null;
                    }
                    if (!reader.IsDBNull(3))
                    {
                        poco.CurrentRate = reader.GetDecimal(3);
                    }
                    else
                    {
                        poco.CurrentRate = null;
                    }
                    if (!reader.IsDBNull(4))
                    {
                        poco.Currency = reader.GetString(4);
                    }
                    else
                    {
                        poco.Currency = null;
                    }
                    if (!reader.IsDBNull(5))
                    {
                        poco.Country = reader.GetString(5);
                    }
                    else
                    {
                        poco.Country = null;
                    }
                    if (!reader.IsDBNull(6))
                    {
                        poco.Province = reader.GetString(6);
                    }
                    else
                    {
                        poco.Province = null;
                    }
                    if (!reader.IsDBNull(7))
                    {
                        poco.Street = reader.GetString(7);
                    }
                    else
                    {
                        poco.Street = null;
                    }
                    if (!reader.IsDBNull(8))
                    {
                        poco.City = reader.GetString(8);
                    }
                    else
                    {
                        poco.City = null;
                    }
                    if (!reader.IsDBNull(9))
                    {
                        poco.PostalCode = reader.GetString(9);
                    }
                    else
                    {
                        poco.PostalCode = null;
                    }

                    poco.TimeStamp = (byte[])reader[10];

                    pocos[position] = poco;

                    position++;

                }
                con.Close();
            }
            return pocos.Where(a => a != null).ToList();
        }

        public IList<ApplicantProfilePoco> GetList(Expression<Func<ApplicantProfilePoco, bool>> where, params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantProfilePoco GetSingle(Expression<Func<ApplicantProfilePoco, bool>> where, params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            IQueryable<ApplicantProfilePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params ApplicantProfilePoco[] items)
        {
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                foreach (ApplicantProfilePoco poco in items)
                {

                    cmd.CommandText = @"DELETE FROM  [JOB_PORTAL_DB].[dbo].[Applicant_Profiles]
                                        where [Id]=@Id";


                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    con.Open();
                    int rowaffect = cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
        }

        public void Update(params ApplicantProfilePoco[] items)
        {
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                foreach (ApplicantProfilePoco poco in items)
                {

                    cmd.CommandText = @"UPDATE  [JOB_PORTAL_DB].[dbo].[Applicant_Profiles]
                                        SET [Login]=@Login,[Current_Salary]=@Current_Salary,
                                        [Current_Rate]=@Current_Rate,[Currency]=@Currency
                                       ,[Country_Code]=@Country_Code,[State_Province_Code]=@State_Province_Code,
                                        [Street_Address]=@Street_Address,[City_Town]=@City_Town,[Zip_Postal_Code]=@Zip_Postal_Code
                                        where [Id]=@Id";




                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Login", poco.Login);
                    cmd.Parameters.AddWithValue("@Current_Salary", poco.CurrentSalary);
                    cmd.Parameters.AddWithValue("@Current_Rate", poco.CurrentRate);
                   // cmd.Parameters.AddWithValue("@Currency", poco.CurrentRate);
                    cmd.Parameters.AddWithValue("@Currency", poco.Currency);
                    cmd.Parameters.AddWithValue("@Country_Code", poco.Country);
                    cmd.Parameters.AddWithValue("@State_Province_Code", poco.Province);
                    cmd.Parameters.AddWithValue("@Street_Address", poco.Street);
                    cmd.Parameters.AddWithValue("@Zip_Postal_Code", poco.PostalCode);
                    cmd.Parameters.AddWithValue("@City_Town", poco.City);

                    con.Open();
                    int rowaffect = cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
        }
    }
}
