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
   public class DriverDAL : IBaseCrud<Driver>,IConvertToObject<Driver>
    {
        public int Add(Driver model)
        {
            throw new NotImplementedException();
        }

        public Driver Get(int id)
        {
            throw new NotImplementedException();
        }

        public Driver Get(Driver model)
        {
            throw new NotImplementedException();
        }
/// <summary>
/// 
/// </summary>
/// <returns></returns>
        public List<Driver> GetAll()
        {
            try
            {
                List<Driver> result;
                using (var connection = SqlHelper.GetConnection())
                {

                    using (SqlCommand command = new SqlCommand("dbo.usp_DriverGetAll", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<Driver>();
                            while (reader.Read())
                            {

                                Driver driver = ToObjectReader(reader);
                                result.Add(driver);


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

        public int Modify(Driver model)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            throw new NotImplementedException();
        }

        public int Remove(Driver model)
        {
            throw new NotImplementedException();
        }

        public int Remove(string id)
        {
            throw new NotImplementedException();
        }

        public Driver ToObject(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
        private Driver ToObjectReader(SqlDataReader reader)
        {
            Driver driver = new Driver();
            driver.Driver_ID =int.Parse( reader["Driver_ID"].ToString());
            driver.Name = reader["Name"].ToString();
            driver.LastName = reader["LastName"].ToString();
          //  driver.User_ID =(User) reader["UserID"];
            driver.InsertBy = int.Parse(reader["InsertBy"].ToString());
            //car.InsertDate =(DateTime) reader["InsertDate"];
            return driver;
        }
    }
}
