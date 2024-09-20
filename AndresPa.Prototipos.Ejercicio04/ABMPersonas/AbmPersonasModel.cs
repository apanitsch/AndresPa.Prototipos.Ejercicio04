namespace AndresPa.Prototipos.Ejercicio04.ABMPersonas;
internal class AbmPersonasModel
{
    public List<Persona> Personas { get; private set; } =
    [
        new Persona { DNI = 10000010, Nombre = "Mónica", Apellido = "Torres", TipoTelefono = TiposTelefono.Otro, CodigoPais = 54, CodigoArea = 11, Numero = 98765432 },
        new Persona { DNI = 10000011, Nombre = "Jorge", Apellido = "Domínguez", TipoTelefono = TiposTelefono.Trabajo, CodigoPais = 54, CodigoArea = 264, Numero = 6543210 },
        new Persona { DNI = 10000012, Nombre = "Natalia", Apellido = "Mendoza", TipoTelefono = TiposTelefono.Casa, CodigoPais = 54, CodigoArea = 354, Numero = 4441122 },
        new Persona { DNI = 10000013, Nombre = "Daniel", Apellido = "Silva", TipoTelefono = TiposTelefono.Casa, CodigoPais = 54, CodigoArea = 291, Numero = 7774455 },
        new Persona { DNI = 10000014, Nombre = "Patricia", Apellido = "Castro", TipoTelefono = TiposTelefono.Trabajo, CodigoPais = 54, CodigoArea = 298, Numero = 5556677 },
    ];

    public string BorrarPersona(Persona persona)
    {
        Personas.Remove(persona);
        return null; //ok.
    }


}
