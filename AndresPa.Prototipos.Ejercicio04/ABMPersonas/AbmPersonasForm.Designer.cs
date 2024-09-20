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
        button5 = new Button();
        button4 = new Button();
        comboBox1 = new ComboBox();
        label7 = new Label();
        textBox7 = new TextBox();
        label6 = new Label();
        textBox6 = new TextBox();
        label5 = new Label();
        textBox5 = new TextBox();
        label4 = new Label();
        label3 = new Label();
        textBox3 = new TextBox();
        label2 = new Label();
        textBox2 = new TextBox();
        label1 = new Label();
        textBox1 = new TextBox();
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
        edicionGrupo.Controls.Add(button5);
        edicionGrupo.Controls.Add(button4);
        edicionGrupo.Controls.Add(comboBox1);
        edicionGrupo.Controls.Add(label7);
        edicionGrupo.Controls.Add(textBox7);
        edicionGrupo.Controls.Add(label6);
        edicionGrupo.Controls.Add(textBox6);
        edicionGrupo.Controls.Add(label5);
        edicionGrupo.Controls.Add(textBox5);
        edicionGrupo.Controls.Add(label4);
        edicionGrupo.Controls.Add(label3);
        edicionGrupo.Controls.Add(textBox3);
        edicionGrupo.Controls.Add(label2);
        edicionGrupo.Controls.Add(textBox2);
        edicionGrupo.Controls.Add(label1);
        edicionGrupo.Controls.Add(textBox1);
        edicionGrupo.Enabled = false;
        edicionGrupo.Location = new Point(12, 311);
        edicionGrupo.Name = "edicionGrupo";
        edicionGrupo.Size = new Size(776, 251);
        edicionGrupo.TabIndex = 1;
        edicionGrupo.TabStop = false;
        // 
        // button5
        // 
        button5.Location = new Point(596, 183);
        button5.Name = "button5";
        button5.Size = new Size(75, 31);
        button5.TabIndex = 16;
        button5.Text = "&Aceptar";
        button5.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new Point(677, 183);
        button4.Name = "button4";
        button4.Size = new Size(75, 31);
        button4.TabIndex = 15;
        button4.Text = "&Cancelar";
        button4.UseVisualStyleBackColor = true;
        // 
        // comboBox1
        // 
        comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(19, 127);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(241, 23);
        comboBox1.TabIndex = 14;
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
        // textBox7
        // 
        textBox7.Location = new Point(460, 127);
        textBox7.Name = "textBox7";
        textBox7.Size = new Size(292, 23);
        textBox7.TabIndex = 12;
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
        // textBox6
        // 
        textBox6.Location = new Point(361, 127);
        textBox6.Name = "textBox6";
        textBox6.Size = new Size(93, 23);
        textBox6.TabIndex = 10;
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
        // textBox5
        // 
        textBox5.Location = new Point(266, 127);
        textBox5.Name = "textBox5";
        textBox5.Size = new Size(89, 23);
        textBox5.TabIndex = 8;
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
        // textBox3
        // 
        textBox3.Location = new Point(534, 63);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(218, 23);
        textBox3.TabIndex = 4;
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
        // textBox2
        // 
        textBox2.Location = new Point(266, 63);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(262, 23);
        textBox2.TabIndex = 2;
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
        // textBox1
        // 
        textBox1.Location = new Point(19, 63);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(241, 23);
        textBox1.TabIndex = 0;
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
        // 
        // personasLista
        // 
        personasLista.Columns.AddRange(new ColumnHeader[] { dniColumna, nombreColumna, apellidoColumna });
        personasLista.Location = new Point(6, 22);
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
    private TextBox textBox6;
    private Label label5;
    private TextBox textBox5;
    private Label label4;
    private Label label3;
    private TextBox textBox3;
    private Label label2;
    private TextBox textBox2;
    private Label label1;
    private TextBox textBox1;
    private Label label7;
    private TextBox textBox7;
    private ComboBox comboBox1;
    private Button button5;
    private Button button4;
    private GroupBox listaGrupo;
    private Button modificarBoton;
    private Button borrarBoton;
    private Button nuevaBoton;
    private ListView personasLista;
    private ColumnHeader dniColumna;
    private ColumnHeader nombreColumna;
    private ColumnHeader apellidoColumna;
}
