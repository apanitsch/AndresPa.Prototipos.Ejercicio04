using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AndresPa.Prototipos.Ejercicio04.Almacenes;

/// <summary>
/// STATIC=>Sólo puede haber UNA instancia de esta clase durante la ejecución del sistema.
/// i.e.: sólo puede existir UN almacen de personas.
/// </summary>
internal static class PersonasAlmacen
{
    //Tengo una lista privada que YO (YO soy la clase PersonasAlmacen) puedo modificar.
    private static List<PersonaEntidad> personas = new List<PersonaEntidad>();

    //Muestro una lista pública con todas las personas para que el resto del sistema consulte.
    public static IReadOnlyCollection<PersonaEntidad> Personas => personas.AsReadOnly();



    //Método para grabar los datos a archivo:
    public static void Grabar()
    {
        //pasar la lista de personas a un formato llamado JSON.
        //básicamente es transformar la lista en un string muy muy grande
        //con los datos de todas las personas.
        var datos = JsonSerializer.Serialize(personas);

        //Grabarlo en disco:
        File.WriteAllText("Personas.json", datos);
    }

    //Método para leer los datos.
    public static void Leer()
    {
        if (!File.Exists("Personas.json")) //si el archivo no existe no tengo nada que hacer.
        {
            return;
        }

        var datos = File.ReadAllText("Personas.json");

        personas = JsonSerializer.Deserialize<List<PersonaEntidad>>(datos)!;
    }

    //Eeeeeee.... y dónde está mi archivo?
    //Muy lindo pero quién hace que estos métodos se ejecuten?
}
