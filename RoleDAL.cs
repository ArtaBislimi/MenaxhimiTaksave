using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MenaxhimiTaksit.BO;
using MenaxhimiTaksit.BO.Interfaces;

namespace MenaxhimiTaksit.DAL
{
  
    public class RoleDAL : IBaseCrud<Role>,IConvertToObject<Role>
    {
       
       
        public string _connectionString = ConfigurationManager.ConnectionStrings["MenaxhimiTaksit"].ConnectionString;
        public int Add(Role model)
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("dbo.usp_Role_Insert", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("RoleId", model.ID);
                command.Parameters.AddWithValue("RoleName", model.Name);
                command.Parameters.AddWithValue("InsertBy", model.InsertBy);
                command.Parameters.AddWithValue("InsertDate", model.InsertDate);

                int rowAffected = command.ExecuteNonQuery();

                command.Dispose();
                connection.Close();
                connection.Dispose();

                return rowAffected;


            }
            catch (Exception )
            {
                MessageBox.Show("Roli juaj eshte regjistruar me sukses !");
                return -1;
               
            }
        }

        //int (>0 mire, =0, -1 gabim), bool (true/false), void(throw)
        public int Modify(Role model)
        {
            throw new System.NotImplementedException();
        }

        public int Remove(int id)
        {
            using (var connection = SqlHelper.GetConnection())
            {

                using (var command = SqlHelper.Command(connection, "dbo.usp_Role_RemoveById"))
                {
                    command.Parameters.AddWithValue("RoleID", id);
                    int result = command.ExecuteNonQuery();
                    return result;
                }
            }
        }

        public int Remove(Role model)
        {
            throw new System.NotImplementedException();
        }

        public Role Get(int id)
        {

            try
            {
                Role role= null;
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("dbo.usp_Roles_GetById", connection))
                    {
                        command.Parameters.AddWithValue("id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            
                            if (reader.Read())
                            {
                                #region Test
                                //ketu ndodhe konvertimi i nje rresht nga databaza ne nje objekt te c# (objekt klases)
                                //role = new Role();
                                //role.ID = int.Parse(reader["ID"].ToString());
                                //role.Name = reader["Name"].ToString();
                                //if (reader["Description"] != DBNull.Value)
                                //    role.Description = reader["Description"].ToString();
                                #endregion
                                role = ToObject(reader);

                            }
                        }
                    }
                }

                return role;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public Role Get(Role model)
        {
            throw new System.NotImplementedException();
        }

        public List<Role> GetAll()
        {
            try
            {
                List<Role> result = null;
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("dbo.usp_Roles_GetAll", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<Role>();   
                            while (reader.Read())
                            {
                                #region Test
                                //ketu ndodhe konvertimi i nje rresht nga databaza ne nje objekt te c# (objekt klases)
                                //Role role = new Role();
                                //role.ID = int.Parse(reader["ID"].ToString());
                                //role.Name = reader["Name"].ToString();
                                //if (reader["Description"] != DBNull.Value)
                                //    role.Description = reader["Description"].ToString();
                                #endregion
                                Role role = ToObject(reader);
                                result.Add(role);
                                

                            }
                        }
                    }
                }

                return result;
            }
            catch (Exception e)
            {
               
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public Role ToObject(SqlDataReader reader)
        {
            Role role = new Role();
            role.ID = reader["Role_ID"].ToString();
            role.Name = reader["RoleName"].ToString();
            role.InsertBy = int.Parse(reader["InsertBy"].ToString());
            role.InsertDate = (DateTime)reader["InsertDate"];
            //role.LastUpdateBy = int.Parse(reader["LUB"].ToString());
            //role.LastUpdateDate = (DateTime)reader["LUB"];
            //role.LastUpdateNo = int.Parse(reader["LUN"].ToString());
            return role;
        }

        public int Remove(string id)
        {
            throw new NotImplementedException();
        }
    }
}