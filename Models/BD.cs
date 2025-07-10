using Microsoft.Data.SqlClient;
using Dapper;

namespace TP06.Models;

public static class BD
{
    private static string _connectionString = @"Server=localhost;DataBase=NombreBase;Integrated Security = True;TrustServerCertificate = True;";


    public static int Login(string email, string contraseña)
    {
        int ID=-1;
        using(SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT ID FROM Usuarios WHERE email = @pEmail AND contraseña = @pContraseña";
            ID = connection.QueryFirstOrDefault<int>(query, new {pEmail = email, pContraseña = contraseña});
        }
        return ID;

    }

    public static Usuario GetUsuario(int ID)
    {
        Usuario usuario = null;
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Usuarios WHERE ID = @pID";
            usuario = connection.QueryFirstOrDefault<Usuario>(query, new {pID = ID});
        }
        return usuario;
    }
    public static List<DatoFamiliar> GetDatoFamiliar(int id)
    {
        List<DatoFamiliar> familiares = null;
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM DatoFamiliar WHERE IdUsuario = @pID";
            familiares = connection.Query<DatoFamiliar>(query, new {pID = id}).ToList();
        }
        return familiares;
    }
    
    public static List<DatoInteres> GetDatoInteres(int id)
    {
        List<DatoInteres> datosInteres = null;
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM DatoInteres WHERE IdUsuario = @pID";
            datosInteres = connection.Query<DatoInteres>(query, new {pID = id}).ToList();
        }
        return datosInteres;
    }
}
