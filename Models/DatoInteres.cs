namespace TP06;
public class DatoInteres
{
    public int Id {get; private set;}
    public int IdUsuario {get; private set;}
    public int TipoInteres {get; private set;} /* 1-Hobby, 2-Serie, 3- Amigo, 4-Gusto */
    public string Interes {get; private set;}


    public DatoInteres (int Id, int IdUsuario, int TipoInteres, string Interes) 
    {
        this.Id = Id;
        this.Id = IdUsuario;
        this.TipoInteres = TipoInteres;
        this.Interes = Interes;
    }

    public DatoInteres ()
    {
        
    }



}