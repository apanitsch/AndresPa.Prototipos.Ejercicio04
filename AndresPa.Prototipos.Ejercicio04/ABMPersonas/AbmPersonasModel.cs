

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

    internal string ModificarPersona(Persona personaModificada)
    {
        //Validaciones
        if (personaModificada.DNI < 1_000_000 || personaModificada.DNI > 99_999_999)
        {
            return "El documento debe tener 7 u 8 dígitos.";
        }

        if (personaModificada.Nombre.Length == 0)
        {
            return "El nombre es requerido.";
        }

        if (personaModificada.Apellido.Length == 0)
        {
            return "El apellido es requerido.";
        }

        if (personaModificada.CodigoPais < 0 || personaModificada.CodigoPais > 99)
        {
            return "El código de país debe tener hasta 2 cifras";
        }

        if (personaModificada.CodigoArea < 0 || personaModificada.CodigoArea > 99)
        {
            return "El código de área debe tener hasta 2 cifras";
        }

        if (personaModificada.Numero < 100_000 || personaModificada.Numero > 99_999_999)
        {
            return "El número de teléfono debe tener entre 6 y 8 digitos.";
        }

        foreach (var persona in Personas)
        {
            if (persona.DNI == personaModificada.DNI)
            {
                //Estilo 1: copio los datos (normalmente es lo que funciona)...
                persona.Apellido = personaModificada.Apellido;
                persona.Nombre = personaModificada.Nombre;
                persona.TipoTelefono = personaModificada.TipoTelefono;
                persona.CodigoPais = personaModificada.CodigoPais;
                persona.CodigoArea = personaModificada.CodigoArea;
                persona.Numero = personaModificada.Numero;

                //Estilo 2: reemplazo los objetos. Pero OJOOOOOO no siempre se puede.
                //Personas.Remove(persona);
                //Personas.Add(personaModificada);
                return null;
            }
        }
    }

    internal string NuevaPersona(Persona persona)
    {
        //Validaciones
        if (persona.DNI < 1_000_000 || persona.DNI > 99_999_999)
        {
            return "El documento debe tener 7 u 8 dígitos.";
        }

        if (persona.Nombre.Length == 0)
        {
            return "El nombre es requerido.";
        }

        if (persona.Apellido.Length == 0)
        {
            return "El apellido es requerido.";
        }

        if (persona.CodigoPais < 0 || persona.CodigoPais > 99)
        {
            return "El código de país debe tener hasta 2 cifras";
        }

        if (persona.CodigoArea < 0 || persona.CodigoArea > 99)
        {
            return "El código de área debe tener hasta 2 cifras";
        }

        if (persona.Numero < 100_000 || persona.Numero > 99_999_999)
        {
            return "El número de teléfono debe tener entre 6 y 8 digitos.";
        }

        //tengo q ver q no exista una persona con el mismo DNI
        foreach (var personaEx in Personas)
        {
            if (personaEx.DNI == persona.DNI)
            {
                return $"Ya existe una persona con DNI {persona.DNI}";
            }
        }

        Personas.Add(persona);
        return null; //null si está ok, si no, un mensaje de error.
    }
}
