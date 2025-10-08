using CrudArriendo.Domain.Entities;
using CrudArriendo.Domain.Interfaces;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace CrudArriendo.Infrastucture.Repositories
{
    public class DuenoRepository : IDuenoRepository
    {
        private readonly string _connectionString;

        public DuenoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Dueno dueno)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("insertardueno", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id", dueno.Id);
                command.Parameters.AddWithValue("@nombre", dueno.Nombre);
                command.Parameters.AddWithValue("@telefono", dueno.Telefono);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Dueno? GetById(int id)
        {
            Dueno? dueno = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("consultarDueno", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    dueno = new Dueno
                    {
                        Id = (int)reader["id"],
                        Nombre = reader["nombre"].ToString(),
                        Telefono = reader["telefono"].ToString()
                    };
                }
            }

            return dueno;
        }

        public IEnumerable<Dueno> GetAll()
        {
            var duenos = new List<Dueno>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("buscarTodosRegistros", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    duenos.Add(new Dueno
                    {
                        Id = (int)reader["id"],
                        Nombre = reader["nombre"].ToString(),
                        Telefono = reader["telefono"].ToString()
                    });
                }
            }

            return duenos;
        }

        public void Update(Dueno dueno)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("modificardueno", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@id", dueno.Id);
                command.Parameters.AddWithValue("@nombre", dueno.Nombre);
                command.Parameters.AddWithValue("@telefono", dueno.Telefono);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("eliminarDueno", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
