using AndresPa.Prototipos.Ejercicio04.ABMPersonas;
using System.DirectoryServices;

namespace AndresPa.Prototipos.Ejercicio04;

public partial class AbmPersonasForm : Form
{
    private AbmPersonasModel modelo = new();

    public AbmPersonasForm()
    {
        InitializeComponent();
    }

    private void AbmPersonasForm_Load(object sender, EventArgs e)
    {
        listaGrupo.Enabled = true;
        edicionGrupo.Enabled = false;

        //para mostrar el texto en la lista desplegable
        //el combo va a hacer ToString() del objeto que pasemos.
        TipoCelCombo.Items.Add(TiposTelefono.Trabajo);
        TipoCelCombo.Items.Add(TiposTelefono.Casa);
        TipoCelCombo.Items.Add(TiposTelefono.Otro);
        //Quedó sin seleccion (vacío) y eso nos puede dar error. Entonces....
        TipoCelCombo.SelectedItem = TiposTelefono.Trabajo;

        ActualizarLista();
    }

    private void borrarBoton_Click(object sender, EventArgs e)
    {
        if (personasLista.SelectedItems.Count != 1)
        {
            MessageBox.Show("Seleccione una (y sólo una) persona a borrar.", "Ejercicio 04", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var item = personasLista.SelectedItems[0];
        var persona = (Persona)item.Tag;

        if (MessageBox.Show($"Se dispone a borrar los datos de {persona.Nombre} {persona.Apellido}. ¿Está ud. seguro?", "Ejercicio 04", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
        {
            return;
        }

        var error = modelo.BorrarPersona(persona);
        if (error != null)
        {
            MessageBox.Show(error);
            return;
        }

        //está todo bien, la persona se borró de la lista.
        ActualizarLista();
    }

    private void ActualizarLista()
    {
        personasLista.Items.Clear();

        //cargar la lista con datos.
        foreach (var persona in modelo.Personas)
        {
            //agregar a la lista.
            ListViewItem item = new ListViewItem();
            item.Text = persona.DNI.ToString();
            item.SubItems.Add(persona.Nombre);
            item.SubItems.Add(persona.Apellido);
            item.Tag = persona;
            personasLista.Items.Add(item);
        }
    }

    private void nuevaBoton_Click(object sender, EventArgs e)
    {
        aceptarBoton.Enabled = true; //"nueva"
        aceptarModificar.Enabled = false;
        listaGrupo.Enabled = false;
        edicionGrupo.Enabled = true;
    }

    private void cancelarBoton_Click(object sender, EventArgs e)
    {
        BorrarDatosEdicion();
        listaGrupo.Enabled = true;
        edicionGrupo.Enabled = false;
    }

    private void aceptarBoton_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(DNIText.Text, out int dni))
        {
            MessageBox.Show($"No ha ingresado un DNI válido.", "Ejercicio 04", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!int.TryParse(CodPaisText.Text, out int codPais))
        {
            MessageBox.Show($"No ha ingresado un código de país válido.", "Ejercicio 04", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!int.TryParse(CodAreaText.Text, out int codArea))
        {
            MessageBox.Show($"No ha ingresado un código de área válido.", "Ejercicio 04", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!int.TryParse(NumeroText.Text, out int numero))
        {
            MessageBox.Show($"No ha ingresado un número de teléfono válido.", "Ejercicio 04", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Persona nueva = new Persona();
        nueva.DNI = dni;
        nueva.Apellido = ApellidoText.Text;
        nueva.Nombre = NombreText.Text;
        nueva.TipoTelefono = (TiposTelefono)TipoCelCombo.SelectedItem;
        nueva.CodigoPais = codPais;
        nueva.CodigoArea = codArea;
        nueva.Numero = numero;

        var error = modelo.NuevaPersona(nueva);
        if (error != null)
        {
            MessageBox.Show(error, "Ejercicio 04", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        //todo ok.
        ActualizarLista();

        BorrarDatosEdicion();

        edicionGrupo.Enabled = false;
        listaGrupo.Enabled = true;
    }


    private void BorrarDatosEdicion()
    {
        DNIText.Text = string.Empty;
        ApellidoText.Text = string.Empty;
        NombreText.Text = string.Empty;
        CodPaisText.Text = string.Empty;
        CodAreaText.Text = string.Empty;
        NumeroText.Text = string.Empty;
    }

    private void modificarBoton_Click(object sender, EventArgs e)
    {
        if (personasLista.SelectedItems.Count != 1)
        {
            MessageBox.Show("Seleccione una (y sólo una) persona a modificar.", "Ejercicio 04", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        listaGrupo.Enabled = false;
        edicionGrupo.Enabled = true;

        aceptarBoton.Enabled = false; //"nueva"
        aceptarModificar.Enabled = true;

        var item = personasLista.SelectedItems[0];
        var persona = (Persona)item.Tag;

        DNIText.Text = persona.DNI.ToString();
        ApellidoText.Text = persona.Apellido;
        NombreText.Text = persona.Nombre;
        TipoCelCombo.SelectedItem = persona.TipoTelefono;
        CodPaisText.Text = persona.CodigoPais.ToString();
        CodAreaText.Text = persona.CodigoArea.ToString();
        NumeroText.Text = persona.Numero.ToString();
    }

    private void aceptarModificar_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(DNIText.Text, out int dni))
        {
            MessageBox.Show($"No ha ingresado un DNI válido.", "Ejercicio 04", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!int.TryParse(CodPaisText.Text, out int codPais))
        {
            MessageBox.Show($"No ha ingresado un código de país válido.", "Ejercicio 04", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!int.TryParse(CodAreaText.Text, out int codArea))
        {
            MessageBox.Show($"No ha ingresado un código de área válido.", "Ejercicio 04", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!int.TryParse(NumeroText.Text, out int numero))
        {
            MessageBox.Show($"No ha ingresado un número de teléfono válido.", "Ejercicio 04", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Persona personaModificada = new Persona();
        personaModificada.DNI = dni;
        personaModificada.Apellido = ApellidoText.Text;
        personaModificada.Nombre = NombreText.Text;
        personaModificada.TipoTelefono = (TiposTelefono)TipoCelCombo.SelectedItem;
        personaModificada.CodigoPais = codPais;
        personaModificada.CodigoArea = codArea;
        personaModificada.Numero = numero;

        var error = modelo.ModificarPersona(personaModificada);
        if (error != null)
        {
            MessageBox.Show(error, "Ejercicio 04", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        //todo ok.
        ActualizarLista();

        BorrarDatosEdicion();

        edicionGrupo.Enabled = false;
        listaGrupo.Enabled = true;
    }
}
