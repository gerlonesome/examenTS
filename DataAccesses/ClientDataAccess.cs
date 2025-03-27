using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.Entities;

namespace Examen.DataAccesses
{
    class ClientDataAccess
    {
        public Client AgregarPaciente(Client newClient)
        {
            DataAccessSQLserver sql = new DataAccessSQLserver();

            SqlConnection connection = new SqlConnection(sql.connectionString);
            connection.Open();
            SqlCommand comando = new SqlCommand("CLIENT_INSERT", connection);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.Add("@nombreCliente", SqlDbType.VarChar).Value = string.IsNullOrEmpty(newClient.nombreCliente) ? string.Empty : newClient.nombreCliente;
            comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = string.IsNullOrEmpty(newClient.telefono) ? string.Empty : newClient.telefono;
            comando.Parameters.Add("@mail", SqlDbType.VarChar).Value = string.IsNullOrEmpty(newClient.mail) ? string.Empty : newClient.mail;

            comando.ExecuteNonQuery();
            connection.Close();

            return newClient;
        }
    }
}
