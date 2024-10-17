using AndresPa.Prototipos.Ejercicio04.Almacenes;

namespace AndresPa.Prototipos.Ejercicio04;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        //Cargar los datos desde almacenes.
        PersonasAlmacen.Leer();

        Application.Run(new AbmPersonasForm()); //La ejecucion mientras dura el programa está detenida acá.

        //Grabar los datos desde almacenes.
        PersonasAlmacen.Grabar();


        //No se puede crear una instancia de PersonasAlmacen utilizando "new"
        //var almacenPersonas = new PersonasAlmacen();

        //No se puede asignar la instancia de PersonasAlmacen a una variable.
        //PersonasAlmacen personasAlmacen = null;

        //Se accede al UNICO objeto existe de la clase estática
        //a través de el nombre de clase directamente.
        //var persona = PersonasAlmacen.ObtenerPersona(25666777);
    }
}