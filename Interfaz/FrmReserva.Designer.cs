namespace AgenciaTours.Interfaz;

partial class FrmReserva
{
    private System.ComponentModel.IContainer? components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components is not null)
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        label1 = new Label();
        txtCliente = new TextBox();
        lblTipo = new Label();
        lstTours = new ListBox();
        label3 = new Label();
        lblPrecio = new Label();
        lblDificultad = new Label();
        label2 = new Label();
        txtPersonas = new TextBox();
        label4 = new Label();
        dtpFechaTour = new DateTimePicker();
        label5 = new Label();
        lstIdioma = new ListBox();
        btnAceptar = new Button();
        btnCancelar = new Button();
        errorProvider1 = new ErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(25, 20);
        label1.Name = "label1";
        label1.Size = new Size(140, 20);
        label1.TabIndex = 0;
        label1.Text = "Nombre del cliente:";
        // 
        // txtCliente
        // 
        txtCliente.Location = new Point(235, 17);
        txtCliente.Name = "txtCliente";
        txtCliente.Size = new Size(230, 27);
        txtCliente.TabIndex = 1;
        // 
        // lblTipo
        // 
        lblTipo.AutoSize = true;
        lblTipo.Location = new Point(25, 91);
        lblTipo.Name = "lblTipo";
        lblTipo.Size = new Size(134, 20);
        lblTipo.TabIndex = 2;
        lblTipo.Text = "Seleccione un tour:";
        // 
        // lstTours
        // 
        lstTours.FormattingEnabled = true;
        lstTours.Location = new Point(267, 66);
        lstTours.Name = "lstTours";
        lstTours.Size = new Size(280, 144);
        lstTours.TabIndex = 3;
        lstTours.SelectedIndexChanged += lstTours_SelectedIndexChanged;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(569, 66);
        label3.Name = "label3";
        label3.Size = new Size(61, 20);
        label3.TabIndex = 4;
        label3.Text = "Tipo: —";
        // 
        // lblPrecio
        // 
        lblPrecio.AutoSize = true;
        lblPrecio.Location = new Point(569, 117);
        lblPrecio.Name = "lblPrecio";
        lblPrecio.Size = new Size(73, 20);
        lblPrecio.TabIndex = 5;
        lblPrecio.Text = "Precio: ₡0";
        // 
        // lblDificultad
        // 
        lblDificultad.AutoSize = true;
        lblDificultad.Location = new Point(569, 166);
        lblDificultad.Name = "lblDificultad";
        lblDificultad.Size = new Size(96, 20);
        lblDificultad.TabIndex = 6;
        lblDificultad.Text = "Dificultad: —";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(37, 250);
        label2.Name = "label2";
        label2.Size = new Size(156, 20);
        label2.TabIndex = 7;
        label2.Text = "Cantidad de personas:";
        // 
        // txtPersonas
        // 
        txtPersonas.Location = new Point(272, 244);
        txtPersonas.Name = "txtPersonas";
        txtPersonas.Size = new Size(125, 27);
        txtPersonas.TabIndex = 8;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(37, 313);
        label4.Name = "label4";
        label4.Size = new Size(106, 20);
        label4.TabIndex = 9;
        label4.Text = "Fecha del tour:";
        // 
        // dtpFechaTour
        // 
        dtpFechaTour.Location = new Point(267, 308);
        dtpFechaTour.Name = "dtpFechaTour";
        dtpFechaTour.Size = new Size(280, 27);
        dtpFechaTour.TabIndex = 10;
        dtpFechaTour.ValueChanged += dtpFechaTour_ValueChanged;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(37, 377);
        label5.Name = "label5";
        label5.Size = new Size(117, 20);
        label5.TabIndex = 11;
        label5.Text = "Idioma del guía:";
        // 
        // lstIdioma
        // 
        lstIdioma.Enabled = false;
        lstIdioma.FormattingEnabled = true;
        lstIdioma.Items.AddRange(new object[] { "Español ", "Inglés" });
        lstIdioma.Location = new Point(295, 381);
        lstIdioma.Name = "lstIdioma";
        lstIdioma.Size = new Size(150, 104);
        lstIdioma.TabIndex = 12;
        lstIdioma.SelectedIndexChanged += lstIdioma_SelectedIndexChanged;
        // 
        // btnAceptar
        // 
        btnAceptar.Location = new Point(601, 431);
        btnAceptar.Name = "btnAceptar";
        btnAceptar.Size = new Size(94, 29);
        btnAceptar.TabIndex = 13;
        btnAceptar.Text = "Aceptar";
        btnAceptar.UseVisualStyleBackColor = true;
        btnAceptar.Click += btnAceptar_Click;
        // 
        // btnCancelar
        // 
        btnCancelar.Location = new Point(764, 431);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(94, 29);
        btnCancelar.TabIndex = 14;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = true;
        // 
        // errorProvider1
        // 
        errorProvider1.ContainerControl = this;
        // 
        // FrmReserva
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FloralWhite;
        ClientSize = new Size(964, 513);
        Controls.Add(btnCancelar);
        Controls.Add(btnAceptar);
        Controls.Add(lstIdioma);
        Controls.Add(label5);
        Controls.Add(dtpFechaTour);
        Controls.Add(label4);
        Controls.Add(txtPersonas);
        Controls.Add(label2);
        Controls.Add(lblDificultad);
        Controls.Add(lblPrecio);
        Controls.Add(label3);
        Controls.Add(lstTours);
        Controls.Add(lblTipo);
        Controls.Add(txtCliente);
        Controls.Add(label1);
        MinimumSize = new Size(700, 560);
        Name = "FrmReserva";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Nueva reserva";
        Load += FrmReserva_Load;
        ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
    private TextBox txtCliente;
    private Label lblTipo;
    private ListBox lstTours;
    private Label label3;
    private Label lblPrecio;
    private Label lblDificultad;
    private Label label2;
    private TextBox txtPersonas;
    private Label label4;
    private DateTimePicker dtpFechaTour;
    private Label label5;
    private ListBox lstIdioma;
    private Button btnAceptar;
    private Button btnCancelar;
    private ErrorProvider errorProvider1;
}
