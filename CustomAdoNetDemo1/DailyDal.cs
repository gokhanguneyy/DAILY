using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CustomAdoNetDemo1
{
    public class DailyDal
    {
        // burada veritabanı sorgu işlemleri yapılacak. Bu yüzden veritabanına bağlantımız olacak.
        // Bağlantı kodları 4 işlemde de aynı olduğu için burada yazacağız. Bağlantı kodundan sonra da bağlantı kontrol kodunu yazacağız.
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;
             initial catalog=Daily;integrated security=true");

        private void ConnectionCheck()
        {
            if(_connection.State == System.Data.ConnectionState.Closed) {
                _connection.Open();
            }
        }

       


        // Select işlemimizde method türümüz List olacak.
        public List<Daily> Select()
        {
            //List<Daily> demek, Daily içindeki property şeklinde listenin içini doldurulacak demek.

            ConnectionCheck(); 
            SqlCommand command = new SqlCommand("Select * from Daily", _connection);
            SqlDataReader reader = command.ExecuteReader(); 
            List<Daily> dailys = new List<Daily>();
            ReadList(reader, dailys);
            reader.Close(); 
            _connection.Close();
            return dailys;
        }

        private void ReadList(SqlDataReader reader, List<Daily> dailys)
        {// Listeleme yaparken verileri gezip, okuyan kodları ayrı bir method haline getirdim.
            while(reader.Read()) {
                Daily daily = new Daily
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Date = Convert.ToDateTime(reader["Date"]),
                    Name = Convert.ToString(reader["Name"]),
                    Context = Convert.ToString(reader["Context"])
                };

                dailys.Add(daily);
            }
        }


        
        public void Add(Daily daily) // burada parametre belirledik Çünkü
        {
            ConnectionCheck() ;
            SqlCommand command = new SqlCommand("INSERT INTO Daily VALUES(@date, @name, @context)", _connection);

            command.Parameters.AddWithValue("@date", daily.Date);
            command.Parameters.AddWithValue("@name", daily.Name);
            command.Parameters.AddWithValue("@context", daily.Context);

            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Daily daily) { 
            ConnectionCheck();
            SqlCommand command = new SqlCommand("UPDATE Daily SET Date = @date, Name = @name, Context=@context where Id=@id", _connection);

            command.Parameters.AddWithValue("@id", daily.Id);
            command.Parameters.AddWithValue("@date", daily.Date);
            command.Parameters.AddWithValue("@name", daily.Name);
            command.Parameters.AddWithValue("@context", daily.Context);

            command.ExecuteNonQuery ();
            _connection.Close();
        }

        public void Delete(int id) {
            ConnectionCheck();
            SqlCommand command = new SqlCommand("Delete from Daily Where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }


        public List<Daily> GetByName(string key)
        {
            ConnectionCheck();
            SqlCommand command = new SqlCommand("Select * from Daily", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Daily> list = new List<Daily>();
            while (reader.Read())
            {
                Daily daily = new Daily
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Date = Convert.ToDateTime(reader["Date"]),
                    Name = Convert.ToString(reader["Name"]),
                    Context = Convert.ToString(reader["Context"])

                };

                list.Add(daily);
            }
            reader.Close();
            _connection.Close();
            return list;
        }
    }
}
