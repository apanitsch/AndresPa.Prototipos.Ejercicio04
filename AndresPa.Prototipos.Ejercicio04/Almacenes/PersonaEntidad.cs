using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndresPa.Prototipos.Ejercicio04.Almacenes;
internal class PersonaEntidad
{
    //Es una clase de datos. No HACE nada. Solamente contiene todos los datos 
    //que definen una entidad (en este  caso de una persona) en el sistema.
    public int DNI { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string TipoTelefono { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public int CodigoPais { get; set; }
    public int CodigoArea { get; set; }
    public int Numero { get; set; }

    //Este objeto puede tener métodos que operen
    //con SUS datos y SUS parámetros exclusivamente.
    public int CalcularEdad()
    {
        return DateTime.Now.Year - FechaNacimiento.Year;
    }

    //Esto está bien:
    public string NombrePais(Dictionary<int, string> codigosPaises)
    {
        return codigosPaises[CodigoPais];
    }

    //Esto estaría MAL:
    /*
    public string NombrePaisPeroMAL()
    {
        return UnRepositorioDePaises.Obtener(CodigoPais).Nombre;
        //Porque UnRepositorioDePaises es
        //una referencia EXTERNA.
    }
    */


    //Cualquier dato que requiera ser calculado
    //DEBE ser un método: ESTO ESTÁ MAL::
    /*
    public int EdadComoPropiedad
    {
        get
        {
            return DateTime.Now.Year - FechaNacimiento.Year;
        }
    }
    */

}
