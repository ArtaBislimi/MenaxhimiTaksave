using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxhimiTaksit.BO;
using MenaxhimiTaksit.BO.Interfaces;

namespace MenaxhimiTaksit.DAL
{
   public class UserDAL:IBaseCrud<User>,IConvertToObject<User>
    {
        public int Add(User model)
        {
            try
            {
                using (var connection = SqlHelper.GetConnection())
                {

                    using (var command = SqlHelper.Command(connection, "dbo.usp_User_Insert"))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("UserID", model.ID);
                        command.Parameters.AddWithValue("UserName", model.Username);
                        command.Parameters.AddWithValue("UserPass", model.Password);
                        command.Parameters.AddWithValue("ExpireDate", model.ExpiresDate);
                        command.Parameters.AddWithValue("Role_ID", model.RoleID);
                        command.Parameters.AddWithValue("InsertBy", model.InsertBy);
                        command.Parameters.AddWithValue("InsertDate", model.InsertDate);

                        int rowAffected = command.ExecuteNonQuery();
                        command.Dispose();
                        connection.Dispose();

                        return rowAffected;
                    }


                }


            }
            catch (Exception )
            {
                MessageBox.Show("Perdoruesi eshte regjistruar me sukses !");
                return -1;

            }
        }

        public int Modify(User model)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            throw new NotImplementedException();
        }

     
        public int Remove(User model)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(User model)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            try
            {
                List<User> result;
                using (var connection = SqlHelper.GetConnection())
                {

                    using (SqlCommand command = new SqlCommand("dbo.usp_UserGetAll", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<User>();
                            while (reader.Read())
                            {

                                User user = ToObjectReader(reader);
                                result.Add(user);


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

        private User ToObjectReader(SqlDataReader reader)
        {
            User user = new User();
            user.ID = reader["User_ID"].ToString();
            user.Username = reader["Username"].ToString();
            user.Password = reader["userpass"].ToString();
            user.InsertBy =int.Parse( reader["InsertBy"].ToString());
            user.InsertDate = (DateTime)reader["InsertDate"];

            return user;
        }
        public User Login(string username, string password)
        {
            User user = null;
            using (var conn = SqlHelper.GetConnection())
            {
                using (var cmd = SqlHelper.Command(conn, "dbo.usp_Authenticate", CommandType.StoredProcedure))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        //Lexon userin
                        if (reader.Read())
                        {
                            user = ToObject(reader);
                        }
                    }
                }
            }

            return user;
        }

        public User ToObject(SqlDataReader reader)
        {
            User user = new User();

           
            user.Username = reader["Username"].ToString();

             #region Data
            // user.ID = int.Parse(reader["ID"].ToString());
            // user.Password = reader["password"].ToString();
            //user.IsActive = (bool) reader["IsActive"];
            // user.InsertBy = reader["InsertBy"].ToString();
            //user.InsertDate = (DateTime) reader["InsertDate"];
            ////UpdateDate, UpdateNo, UpdateBy
             #endregion

            return user;
        }

        public int Remove(string id)
        {
            try
            {
                using (var connection = SqlHelper.GetConnection())
                {

                    using (var command = SqlHelper.Command(connection, "dbo.usp_User_RemovebyID"))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("ID", id);

                        int rowAffected = command.ExecuteNonQuery();

                        return rowAffected;
                    }


                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;

            }

        }
    }
}
