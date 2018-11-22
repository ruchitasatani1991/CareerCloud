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
    public class SecurityLoginsRoleRepository : BaseADO, IDataRepository<SecurityLoginsRolePoco>
    {
        public void Add(params SecurityLoginsRolePoco[] items)
        {
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                foreach (SecurityLoginsRolePoco poco in items)
                {

                    cmd.CommandText = @"INSERT INTO [JOB_PORTAL_DB].[dbo].[Security_Logins_Roles]
                                       ([Id],[Login],[Role])
                                    VALUES
                                       (@Id,@Login,@Role)";

                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Login", poco.Login);
                    cmd.Parameters.AddWithValue("@Role", poco.Role);
                    

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

        public IList<SecurityLoginsRolePoco> GetAll(params Expression<Func<SecurityLoginsRolePoco, object>>[] navigationProperties)
        {
            SecurityLoginsRolePoco[] pocos = new SecurityLoginsRolePoco[500];
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand("select * from [JOB_PORTAL_DB].[dbo].[Security_Logins_Roles]", con);

                int position = 0;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    SecurityLoginsRolePoco poco = new SecurityLoginsRolePoco();

                    poco.Id = reader.GetGuid(0);
                    poco.Login = reader.GetGuid(1);
                    poco.Role = reader.GetGuid(2);
                    poco.TimeStamp = (byte[])reader[3];

                    pocos[position] = poco;

                    position++;

                }
                con.Close();
            }
            return pocos.Where(a => a != null).ToList();
        }

        public IList<SecurityLoginsRolePoco> GetList(Expression<Func<SecurityLoginsRolePoco, bool>> where, params Expression<Func<SecurityLoginsRolePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SecurityLoginsRolePoco GetSingle(Expression<Func<SecurityLoginsRolePoco, bool>> where, params Expression<Func<SecurityLoginsRolePoco, object>>[] navigationProperties)
        {
            IQueryable<SecurityLoginsRolePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params SecurityLoginsRolePoco[] items)
        {
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                foreach (SecurityLoginsRolePoco poco in items)
                {

                    cmd.CommandText = @"DELETE FROM  [JOB_PORTAL_DB].[dbo].[Security_Logins_Roles]
                                        where [Id]=@Id";


                    cmd.Parameters.AddWithValue("@Id", poco.Id);

                    con.Open();
                    int rowaffect = cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
        }

        public void Update(params SecurityLoginsRolePoco[] items)
        {
            using (SqlConnection con = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                foreach (SecurityLoginsRolePoco poco in items)
                {

                    cmd.CommandText = @"UPDATE  [JOB_PORTAL_DB].[dbo].[Security_Logins_Roles]
                                        SET [Login]=@Login,[Role]=@Role                                       
                                        where [Id]=@Id";




                    cmd.Parameters.AddWithValue("@Id", poco.Id);
                    cmd.Parameters.AddWithValue("@Login", poco.Login);
                    cmd.Parameters.AddWithValue("@Role", poco.Role);
                   
                    con.Open();
                    int rowaffect = cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
        }
    }
}
