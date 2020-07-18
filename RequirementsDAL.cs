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
    public class RequirementsDAL : IBaseCrud<Requirements>, IConvertToObject<Requirements>
    {
        public int Add(Requirements model)
        {
            try
            {
                using (var connection = SqlHelper.GetConnection())
                {

                    using (var command = SqlHelper.Command(connection, "dbo.usp_InsertRequirement"))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("Requirement_ID", Requirements.ID);
                        command.Parameters.AddWithValue("User_ID", model.User_ID);
                        command.Parameters.AddWithValue("Role_ID", model.Role_ID);
                        command.Parameters.AddWithValue("DeparturePlace", model.DepaturePlace);
                        command.Parameters.AddWithValue("Day", model.Day);
                        command.Parameters.AddWithValue("Specialrequirements", model.SpecialRequirements);
                        command.Parameters.AddWithValue("Price", model.Price);
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
                MessageBox.Show("Kerkesat e juaja jane regjistruar me sukses !");
                return -1;

            }
        }

        public Requirements Get(int id)
        {
            throw new NotImplementedException();
        }

        public Requirements Get(Requirements model)
        {
            throw new NotImplementedException();
        }

        public List<Requirements> GetAll()
        {
            try
            {
                List<Requirements> result;
                using (var connection = SqlHelper.GetConnection())
                {

                    using (SqlCommand command = new SqlCommand("dbo.usp_GetAllRequirements", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<Requirements>();
                            while (reader.Read())
                            {

                                Requirements requirements = ToObjectReader(reader);
                                result.Add(requirements);


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

        private Requirements ToObjectReader(SqlDataReader reader)
        {

            Requirements requirements = new Requirements();
           // Requirements.ID = int.Parse(reader["Requirement_ID"].ToString());
            requirements.User_ID = reader["User_ID"].ToString();
            requirements.Role_ID = int.Parse(reader["Role_ID"].ToString());
            requirements.DepaturePlace = reader["DepaturePlace"].ToString();
            requirements.Day = (DateTime)reader["Day"];
            requirements.SpecialRequirements = reader["SpecialRequirements"].ToString();
           // requirements.Price =int.Parse( reader["Price"].ToString());
            requirements.InsertBy = int.Parse(reader["InsertBy"].ToString());
            requirements.InsertDate = (DateTime)reader["InsertDate"];

            //requirements.Price = reader["Price"].ToString();
            return requirements;
        }

        public int Modify(Requirements model)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            throw new NotImplementedException();
        }

        public int Remove(Requirements model)
        {
            throw new NotImplementedException();
        }

        public int Remove(string id)
        {
            throw new NotImplementedException();
        }

        public Requirements ToObject(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        //public Requirements ToObject(SqlDataReader reader)
        //{


        //        Requirements requirements = new Requirements();
        //    Requirements.ID = int.Parse(reader["Requirement_ID"].ToString());
        //    requirements.User_ID = reader["User_ID"].ToString();
        //    requirements.Role_ID =int.Parse( reader["Role_ID"].ToString());
        //    requirements.DepaturePlace = reader["DeparturePlace"].ToString();
        //    requirements.SpecialRequirements = reader["SpecialRequirements"].ToString();
        //    //requirements.Price = reader["Price"].ToString();
        //        return requirements;

        //}
    }
}
