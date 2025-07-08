using Microsoft.Data.SqlClient;
using Dapper;

namespace TP06.Models;

public class BD
{
    private static string _connectionString = @"Server=localhost;DataBase=NombreBase;Integrated Security = True;TrustServerCertificate = True;";


    int Login(string email, string contraseña)
    {
        int ID=-1;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT ID FROM Usuarios WHERE email = @pEmail AND contraseña = @pContraseña";
            ID = connection.QueryFirstOrDefault<int>(query, new {pEmail = email, pContraseña = contraseña});
        }
        return ID;

    }
}
