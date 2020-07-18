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
    public class CarDAL : IConvertToObject<Car>, IBaseCrud<Car>
    {
        public int Add(Car model)
        {
            try
            {
                using (var connection = SqlHelper.GetConnection())
                {

                    using (var command = SqlHelper.Command(connection, "dbo.InsertCar"))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("Car_ID", model.Car_ID);
                        command.Parameters.AddWithValue("Registration", model.Registration);
                        command.Parameters.AddWithValue("Firm", model.Firm);
                        command.Parameters.AddWithValue("YearofManufacture", model.Yearofmanufacture);
                        command.Parameters.AddWithValue("Power", model.Power);
                        command.Parameters.AddWithValue("Status", model.Status);
                        command.Parameters.AddWithValue("InsertBy", model.InsertBy);
                        command.Parameters.AddWithValue("InsertDate", model.InsertDate);
                        int rowAffected = command.ExecuteNonQuery();
                        command.Dispose();
                        connection.Dispose();

                        return rowAffected;
                    }


                }


            }
            catch (Exception e)
            {
                MessageBox.Show("Regjistrimi ka perfunduar me sukses !");
                return -1;

            }

        }

        public Car Get(int id)
        {
            throw new NotImplementedException();
        }

        public Car Get(Car model)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            try
            {
                List<Car> result;
                using (var connection = SqlHelper.GetConnection())
                {

                    using (SqlCommand command = new SqlCommand("dbo.usp_CarGetAll", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<Car>();
                            while (reader.Read())
                            {

                                Car car = ToObjectReader(reader);
                                result.Add(car);


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

        public int Modify(Car model)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            throw new NotImplementedException();
        }

        public int Remove(Car model)
        {
            throw new NotImplementedException();
        }

        public int Remove(string id)
        {
            throw new NotImplementedException();
        }

        public Car ToObject(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
        private Car ToObjectReader(SqlDataReader reader)
        {
            Car car = new Car();
            car.Car_ID = int.Parse(reader["Car_ID"].ToString());
            car.Registration = reader["Registration"].ToString();
            car.Firm = reader["Firm"].ToString();
          //  car.Yearofmanufacture = (DateTime)reader["YearofManufacture"];
            car.Power = int.Parse(reader["Power"].ToString());
            car.Status = bool.Parse(reader["Status"].ToString());
            car.InsertBy = int.Parse(reader["InsertBy"].ToString());
            //car.InsertDate =(DateTime) reader["InsertDate"];
            return car;
        }
    }
}
