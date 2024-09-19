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
        listView1 = new ListView();
        dniColumna = new ColumnHeader();
        nombreColumna = new ColumnHeader();
        apellidoColumna = new ColumnHeader();
        groupBox1 = new GroupBox();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        textBox1 = new TextBox();
        label1 = new Label();
        label2 = new Label();
        textBox2 = new TextBox();
        label3 = new Label();
        textBox3 = new TextBox();
        label4 = new Label();
        label5 = new Label();
        textBox5 = new TextBox();
        label6 = new Label();
        textBox6 = new TextBox();
        label7 = new Label();
        textBox7 = new TextBox();
        comboBox1 = new ComboBox();
        button4 = new Button();
        button5 = new Button();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // listView1
        // 
        listView1.Columns.AddRange(new ColumnHeader[] { dniColumna, nombreColumna, apellidoColumna });
        listView1.Location = new Point(12, 12);
        listView1.Name = "listView1";
        listView1.Size = new Size(776, 219);
        listView1.TabIndex = 0;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = View.Details;
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
        // groupBox1
        // 
        groupBox1.Controls.Add(button5);
        groupBox1.Controls.Add(button4);
        groupBox1.Controls.Add(comboBox1);
        groupBox1.Controls.Add(label7);
        groupBox1.Controls.Add(textBox7);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(textBox6);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(textBox5);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(textBox3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(textBox2);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(textBox1);
        groupBox1.Location = new Point(12, 311);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(776, 251);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        // 
        // button1
        // 
        button1.Location = new Point(713, 237);
        button1.Name = "button1";
        button1.Size = new Size(75, 31);
        button1.TabIndex = 2;
        button1.Text = "&Nueva";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(546, 237);
        button2.Name = "button2";
        button2.Size = new Size(161, 31);
        button2.TabIndex = 3;
        button2.Text = "&Borrar seleccionada";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new Point(379, 237);
        button3.Name = "button3";
        button3.Size = new Size(161, 31);
        button3.TabIndex = 4;
        button3.Text = "&Modificar seleccionada";
        button3.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(19, 63);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(241, 23);
        textBox1.TabIndex = 0;
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
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(19, 109);
        label4.Name = "label4";
        label4.Size = new Size(30, 15);
        label4.TabIndex = 7;
        label4.Text = "Tipo";
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
        // comboBox1
        // 
        comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(19, 127);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(241, 23);
        comboBox1.TabIndex = 14;
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
        // button5
        // 
        button5.Location = new Point(596, 183);
        button5.Name = "button5";
        button5.Size = new Size(75, 31);
        button5.TabIndex = 16;
        button5.Text = "&Aceptar";
        button5.UseVisualStyleBackColor = true;
        // 
        // AbmPersonasForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 584);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(groupBox1);
        Controls.Add(listView1);
        Name = "AbmPersonasForm";
        Text = "Form1";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private ListView listView1;
    private ColumnHeader dniColumna;
    private ColumnHeader nombreColumna;
    private ColumnHeader apellidoColumna;
    private GroupBox groupBox1;
    private Button button1;
    private Button button2;
    private Button button3;
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
}
