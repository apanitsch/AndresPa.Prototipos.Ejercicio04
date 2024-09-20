using AndresPa.Prototipos.Ejercicio04.ABMPersonas;

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

        ActualizarLista();
    }

    private void borrarBoton_Click(object sender, EventArgs e)
    {
        if (personasLista.SelectedItems.Count != 1)
        {
            MessageBox.Show("Seleccione una (y sólo una) persona a borrar.");
            return;
        }

        var item = personasLista.SelectedItems[0];
        var persona = (Persona)item.Tag;

        var error = modelo.BorrarPersona(persona);
        if(error != null)
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
}
