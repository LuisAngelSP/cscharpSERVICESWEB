using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FundamentosCSHARP.Models
{
    internal class CervezaBD
    {
        private string connectionString
            = "Data Source=DESKTOP-DUJGV0C\\SQLMASTER;Initial Catalog=jb_java;" +
        "User=sa;Password=123456";

        public List<Cerveza> Get()
        {
            List<Cerveza> cervezas = new List<Cerveza>();

            string query = "SELECT nombre, marca, alcohol,cantidad FROM CERVEZA";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    int Cantidad = reader.GetInt32(3);
                    string Nombre = reader.GetString(0);
                    Cerveza cerveza = new Cerveza(Cantidad, Nombre);
                    cerveza.Alcohol = reader.GetInt32(2);
                    cerveza.Marca = reader.GetString(1);
                    cervezas.Add(cerveza);
                }
                reader.Close();
                connection.Close();
            }

            return cervezas;
        }


        public void Add(Cerveza cerveza)
        {
            string query
                = "INSERT INTO CERVEZA (nombre,marca,alcohol,cantidad) VALUES" +
                "(@nombre, @marca,@alcohol,@cantidad)";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection); // llamar a la conexion 

                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);

                connection.Open();
                command.ExecuteReader();


                connection.Close();
            }

        
    }

        public void Edit(Cerveza cerveza, int Id )
        {
            string query = "UPDATE CERVEZA SET " +
                          "nombre = @nombre, " +
                          "marca = @marca, " +
                          "alcohol = @alcohol, " +
                          "cantidad = @cantidad " +
                          "WHERE id = @id";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand(query, connection); // llamar a la conexion 

          
                command.Parameters.AddWithValue("@nombre", cerveza.Nombre);
                command.Parameters.AddWithValue("@marca", cerveza.Marca);
                command.Parameters.AddWithValue("@alcohol", cerveza.Alcohol);
                command.Parameters.AddWithValue("@cantidad", cerveza.Cantidad);
                command.Parameters.AddWithValue("@id",Id);



                command.ExecuteReader();


                connection.Close();
            }


        }

        public void Delet( int Id)
        {
            string query = "DELETE FROM CERVEZA " +
                          "WHERE id = @id";

            using (var connection = new SqlConnection(connectionString))
            {
           
                var command = new SqlCommand(query, connection); // llamar a la conexion 

                connection.Open();
                command.Parameters.AddWithValue("@id", Id);



                command.ExecuteReader();


                connection.Close();
            }


        }

    }
}
