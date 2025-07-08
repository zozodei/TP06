namespace TP06;
public class Usuario 
{

    public int Id {get; private set;}
    public string Nombre {get; private set;}
    public string Apellido {get; private set;}
    public string Email {get; private set;}
    public string Contraseña {get; private set;}
    public DataTime FechaNacimiento {get; private set;}
    public string Foto {get; private set;}


    public Usuario (int Id, string Nombre, string Apellido, string Email, string Contraseña, DataTime FechaNacimiento, string Foto)
    {
        this.Id = Id;
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Email = Email;
        this.Contraseña = Contraseña;
        this.FechaNacimiento= FechaNacimiento;
        this.Foto = Foto;
    }


    public int obtenerEdad () 
    {
        int edad;
        DataTime hoy;
        hoy = DataTime.Today;
        int edad = hoy.Year - FechaNacimiento.Year;

        if (hoy.Month < FechaNacimiento.Month || 
           (hoy.Month == FechaNacimiento.Month && hoy.Day < FechaNacimiento.Day))
        {
            edad--;
        }
        return edad;
    }
    
}
