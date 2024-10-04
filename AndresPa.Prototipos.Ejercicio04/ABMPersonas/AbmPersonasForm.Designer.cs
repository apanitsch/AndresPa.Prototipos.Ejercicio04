namespace AndresPa.Prototipos.Ejercicio04;

partial class AbmPersonasForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        edicionGrupo = new GroupBox();
        aceptarModificar = new Button();
        aceptarBoton = new Button();
        cancelarBoton = new Button();
        TipoCelCombo = new ComboBox();
        label7 = new Label();
        NumeroText = new TextBox();
        label6 = new Label();
        CodAreaText = new TextBox();
        label5 = new Label();
        CodPaisText = new TextBox();
        label4 = new Label();
        label3 = new Label();
        NombreText = new TextBox();
        label2 = new Label();
        ApellidoText = new TextBox();
        label1 = new Label();
        DNIText = new TextBox();
        listaGrupo = new GroupBox();
        modificarBoton = new Button();
        borrarBoton = new Button();
        nuevaBoton = new Button();
        personasLista = new ListView();
        dniColumna = new ColumnHeader();
        nombreColumna = new ColumnHeader();
        apellidoColumna = new ColumnHeader();
        edicionGrupo.SuspendLayout();
        listaGrupo.SuspendLayout();
        SuspendLayout();
        // 
        // edicionGrupo
        // 
        edicionGrupo.Controls.Add(aceptarModificar);
        edicionGrupo.Controls.Add(aceptarBoton);
        edicionGrupo.Controls.Add(cancelarBoton);
        edicionGrupo.Controls.Add(TipoCelCombo);
        edicionGrupo.Controls.Add(label7);
        edicionGrupo.Controls.Add(NumeroText);
        edicionGrupo.Controls.Add(label6);
        edicionGrupo.Controls.Add(CodAreaText);
        edicionGrupo.Controls.Add(label5);
        edicionGrupo.Controls.Add(CodPaisText);
        edicionGrupo.Controls.Add(label4);
        edicionGrupo.Controls.Add(label3);
        edicionGrupo.Controls.Add(NombreText);
        edicionGrupo.Controls.Add(label2);
        edicionGrupo.Controls.Add(ApellidoText);
        edicionGrupo.Controls.Add(label1);
        edicionGrupo.Controls.Add(DNIText);
        edicionGrupo.Enabled = false;
        edicionGrupo.Location = new Point(12, 311);
        edicionGrupo.Name = "edicionGrupo";
        edicionGrupo.Size = new Size(776, 251);
        edicionGrupo.TabIndex = 1;
        edicionGrupo.TabStop = false;
        // 
        // aceptarModificar
        // 
        aceptarModificar.Location = new Point(502, 183);
        aceptarModificar.Name = "aceptarModificar";
        aceptarModificar.Size = new Size(157, 31);
        aceptarModificar.TabIndex = 17;
        aceptarModificar.Text = "&Aceptar modificaciones";
        aceptarModificar.UseVisualStyleBackColor = true;
        aceptarModificar.Click += aceptarModificar_Click;
        // 
        // aceptarBoton
        // 
        aceptarBoton.Location = new Point(349, 183);
        aceptarBoton.Name = "aceptarBoton";
        aceptarBoton.Size = new Size(125, 31);
        aceptarBoton.TabIndex = 16;
        aceptarBoton.Text = "&Aceptar nueva";
        aceptarBoton.UseVisualStyleBackColor = true;
        aceptarBoton.Click += aceptarBoton_Click;
        // 
        // cancelarBoton
        // 
        cancelarBoton.Location = new Point(677, 183);
        cancelarBoton.Name = "cancelarBoton";
        cancelarBoton.Size = new Size(75, 31);
        cancelarBoton.TabIndex = 15;
        cancelarBoton.Text = "&Cancelar";
        cancelarBoton.UseVisualStyleBackColor = true;
        cancelarBoton.Click += cancelarBoton_Click;
        // 
        // TipoCelCombo
        // 
        TipoCelCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        TipoCelCombo.FormattingEnabled = true;
        TipoCelCombo.Location = new Point(19, 127);
        TipoCelCombo.Name = "TipoCelCombo";
        TipoCelCombo.Size = new Size(241, 23);
        TipoCelCombo.TabIndex = 14;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(460, 109);
        label7.Name = "label7";
        label7.Size = new Size(51, 15);
        label7.TabIndex = 13;
        label7.Text = "Número";
        // 
        // NumeroText
        // 
        NumeroText.Location = new Point(460, 127);
        NumeroText.MaxLength = 8;
        NumeroText.Name = "NumeroText";
        NumeroText.Size = new Size(292, 23);
        NumeroText.TabIndex = 12;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(361, 109);
        label6.Name = "label6";
        label6.Size = new Size(59, 15);
        label6.TabIndex = 11;
        label6.Text = "Cod. Area";
        // 
        // CodAreaText
        // 
        CodAreaText.Location = new Point(361, 127);
        CodAreaText.MaxLength = 2;
        CodAreaText.Name = "CodAreaText";
        CodAreaText.Size = new Size(93, 23);
        CodAreaText.TabIndex = 10;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(266, 109);
        label5.Name = "label5";
        label5.Size = new Size(56, 15);
        label5.TabIndex = 9;
        label5.Text = "Cod. Pais";
        // 
        // CodPaisText
        // 
        CodPaisText.Location = new Point(266, 127);
        CodPaisText.MaxLength = 2;
        CodPaisText.Name = "CodPaisText";
        CodPaisText.Size = new Size(89, 23);
        CodPaisText.TabIndex = 8;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(19, 109);
        label4.Name = "label4";
        label4.Size = new Size(30, 15);
        label4.TabIndex = 7;
        label4.Text = "Tipo";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(534, 45);
        label3.Name = "label3";
        label3.Size = new Size(51, 15);
        label3.TabIndex = 5;
        label3.Text = "Nombre";
        // 
        // NombreText
        // 
        NombreText.Location = new Point(534, 63);
        NombreText.MaxLength = 30;
        NombreText.Name = "NombreText";
        NombreText.Size = new Size(218, 23);
        NombreText.TabIndex = 4;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(266, 45);
        label2.Name = "label2";
        label2.Size = new Size(51, 15);
        label2.TabIndex = 3;
        label2.Text = "Apellido";
        // 
        // ApellidoText
        // 
        ApellidoText.Location = new Point(266, 63);
        ApellidoText.MaxLength = 30;
        ApellidoText.Name = "ApellidoText";
        ApellidoText.Size = new Size(262, 23);
        ApellidoText.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(19, 45);
        label1.Name = "label1";
        label1.Size = new Size(70, 15);
        label1.TabIndex = 1;
        label1.Text = "Documento";
        // 
        // DNIText
        // 
        DNIText.Location = new Point(19, 63);
        DNIText.MaxLength = 8;
        DNIText.Name = "DNIText";
        DNIText.Size = new Size(241, 23);
        DNIText.TabIndex = 0;
        // 
        // listaGrupo
        // 
        listaGrupo.Controls.Add(modificarBoton);
        listaGrupo.Controls.Add(borrarBoton);
        listaGrupo.Controls.Add(nuevaBoton);
        listaGrupo.Controls.Add(personasLista);
        listaGrupo.FlatStyle = FlatStyle.Flat;
        listaGrupo.Location = new Point(12, 12);
        listaGrupo.Name = "listaGrupo";
        listaGrupo.Size = new Size(776, 293);
        listaGrupo.TabIndex = 17;
        listaGrupo.TabStop = false;
        // 
        // modificarBoton
        // 
        modificarBoton.Location = new Point(361, 247);
        modificarBoton.Name = "modificarBoton";
        modificarBoton.Size = new Size(161, 31);
        modificarBoton.TabIndex = 8;
        modificarBoton.Text = "&Modificar seleccionada";
        modificarBoton.UseVisualStyleBackColor = true;
        modificarBoton.Click += modificarBoton_Click;
        // 
        // borrarBoton
        // 
        borrarBoton.Location = new Point(528, 247);
        borrarBoton.Name = "borrarBoton";
        borrarBoton.Size = new Size(161, 31);
        borrarBoton.TabIndex = 7;
        borrarBoton.Text = "&Borrar seleccionada";
        borrarBoton.UseVisualStyleBackColor = true;
        borrarBoton.Click += borrarBoton_Click;
        // 
        // nuevaBoton
        // 
        nuevaBoton.Location = new Point(695, 247);
        nuevaBoton.Name = "nuevaBoton";
        nuevaBoton.Size = new Size(75, 31);
        nuevaBoton.TabIndex = 6;
        nuevaBoton.Text = "&Nueva";
        nuevaBoton.UseVisualStyleBackColor = true;
        nuevaBoton.Click += nuevaBoton_Click;
        // 
        // personasLista
        // 
        personasLista.Columns.AddRange(new ColumnHeader[] { dniColumna, nombreColumna, apellidoColumna });
        personasLista.FullRowSelect = true;
        personasLista.Location = new Point(6, 22);
        personasLista.MultiSelect = false;
        personasLista.Name = "personasLista";
        personasLista.Size = new Size(764, 219);
        personasLista.TabIndex = 5;
        personasLista.UseCompatibleStateImageBehavior = false;
        personasLista.View = View.Details;
        // 
        // dniColumna
        // 
        dniColumna.Text = "DNI";
        // 
        // nombreColumna
        // 
        nombreColumna.Text = "Nombre";
        // 
        // apellidoColumna
        // 
        apellidoColumna.Text = "Apellido";
        // 
        // AbmPersonasForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 584);
        Controls.Add(listaGrupo);
        Controls.Add(edicionGrupo);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Name = "AbmPersonasForm";
        Text = "Alta de personas";
        Load += AbmPersonasForm_Load;
        edicionGrupo.ResumeLayout(false);
        edicionGrupo.PerformLayout();
        listaGrupo.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private GroupBox edicionGrupo;
    private Label label6;
    private TextBox CodAreaText;
    private Label label5;
    private TextBox CodPaisText;
    private Label label4;
    private Label label3;
    private TextBox NombreText;
    private Label label2;
    private TextBox ApellidoText;
    private Label label1;
    private TextBox DNIText;
    private Label label7;
    private TextBox NumeroText;
    private ComboBox TipoCelCombo;
    private Button aceptarBoton;
    private Button cancelarBoton;
    private GroupBox listaGrupo;
    private Button modificarBoton;
    private Button borrarBoton;
    private Button nuevaBoton;
    private ListView personasLista;
    private ColumnHeader dniColumna;
    private ColumnHeader nombreColumna;
    private ColumnHeader apellidoColumna;
    private Button aceptarModificar;
}
