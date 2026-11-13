namespace AgenciaTours.Interfaz;

partial class Form1
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        plnEncabezado = new Panel();
        lblFecha = new Label();
        lblTitulo = new Label();
        lblReservas = new Label();
        btnNueva = new Button();
        btnBuscarCliente = new Button();
        btnEliminar = new Button();
        btnDetalle = new Button();
        pnlResumen = new Panel();
        lblProximas = new Label();
        lblPersonas = new Label();
        lblCulturales = new Label();
        lblAventura = new Label();
        lblIngresos = new Label();
        btnSalir = new Button();
        dgvReservas = new DataGridView();
        colCliente = new DataGridViewTextBoxColumn();
        colTipo = new DataGridViewTextBoxColumn();
        colTour = new DataGridViewTextBoxColumn();
        colFecha = new DataGridViewTextBoxColumn();
        colPersonas = new DataGridViewTextBoxColumn();
        colTotal = new DataGridViewTextBoxColumn();
        colEstado = new DataGridViewTextBoxColumn();
        plnEncabezado.SuspendLayout();
        pnlResumen.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
        SuspendLayout();
        // 
        // plnEncabezado
        // 
        plnEncabezado.BackColor = Color.Teal;
        plnEncabezado.Controls.Add(lblFecha);
        plnEncabezado.Controls.Add(lblTitulo);
        plnEncabezado.Dock = DockStyle.Top;
        plnEncabezado.Location = new Point(0, 0);
        plnEncabezado.Margin = new Padding(6);
        plnEncabezado.Name = "plnEncabezado";
        plnEncabezado.Size = new Size(1370, 83);
        plnEncabezado.TabIndex = 0;
        plnEncabezado.Paint += plnEncabezado_Paint;
        // 
        // lblFecha
        // 
        lblFecha.AutoSize = true;
        lblFecha.ForeColor = Color.White;
        lblFecha.Location = new Point(755, 37);
        lblFecha.Name = "lblFecha";
        lblFecha.Size = new Size(141, 30);
        lblFecha.TabIndex = 2;
        lblFecha.Text = "Fecha actual";
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(13, 37);
        lblTitulo.Margin = new Padding(6, 0, 6, 0);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(291, 37);
        lblTitulo.TabIndex = 1;
        lblTitulo.Text = "BRISA CARIBE TOURS";
        // 
        // lblReservas
        // 
        lblReservas.AutoSize = true;
        lblReservas.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblReservas.ForeColor = Color.DarkGreen;
        lblReservas.Location = new Point(34, 126);
        lblReservas.Name = "lblReservas";
        lblReservas.Size = new Size(227, 30);
        lblReservas.TabIndex = 1;
        lblReservas.Text = "Reservas registradas";
        // 
        // btnNueva
        // 
        btnNueva.BackColor = Color.ForestGreen;
        btnNueva.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnNueva.ForeColor = Color.White;
        btnNueva.Location = new Point(34, 489);
        btnNueva.Name = "btnNueva";
        btnNueva.Size = new Size(180, 45);
        btnNueva.TabIndex = 3;
        btnNueva.Text = "Nueva reserva";
        btnNueva.UseVisualStyleBackColor = false;
        btnNueva.Click += btnNueva_Click;
        // 
        // btnBuscarCliente
        // 
        btnBuscarCliente.BackColor = Color.DodgerBlue;
        btnBuscarCliente.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnBuscarCliente.ForeColor = Color.White;
        btnBuscarCliente.Location = new Point(350, 489);
        btnBuscarCliente.Name = "btnBuscarCliente";
        btnBuscarCliente.Size = new Size(180, 45);
        btnBuscarCliente.TabIndex = 4;
        btnBuscarCliente.Text = "Buscar cliente";
        btnBuscarCliente.UseVisualStyleBackColor = false;
        btnBuscarCliente.Click += button2_Click;
        // 
        // btnEliminar
        // 
        btnEliminar.BackColor = Color.Coral;
        btnEliminar.ForeColor = Color.White;
        btnEliminar.Location = new Point(695, 487);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new Size(286, 45);
        btnEliminar.TabIndex = 5;
        btnEliminar.Text = "Eliminar reserva";
        btnEliminar.UseVisualStyleBackColor = false;
        btnEliminar.Click += btnEliminar_Click;
        // 
        // btnDetalle
        // 
        btnDetalle.BackColor = Color.DarkGreen;
        btnDetalle.Location = new Point(1192, 476);
        btnDetalle.Name = "btnDetalle";
        btnDetalle.Size = new Size(189, 45);
        btnDetalle.TabIndex = 6;
        btnDetalle.Text = "Ver detalle";
        btnDetalle.UseVisualStyleBackColor = false;
        btnDetalle.Click += btnResumen_Click;
        // 
        // pnlResumen
        // 
        pnlResumen.BackColor = Color.Honeydew;
        pnlResumen.Controls.Add(lblProximas);
        pnlResumen.Controls.Add(lblPersonas);
        pnlResumen.Controls.Add(lblCulturales);
        pnlResumen.Controls.Add(lblAventura);
        pnlResumen.Controls.Add(lblIngresos);
        pnlResumen.Location = new Point(34, 607);
        pnlResumen.Name = "pnlResumen";
        pnlResumen.Size = new Size(1347, 112);
        pnlResumen.TabIndex = 7;
        pnlResumen.Paint += pnlResumen_Paint;
        // 
        // lblProximas
        // 
        lblProximas.AutoSize = true;
        lblProximas.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblProximas.ForeColor = Color.DarkGreen;
        lblProximas.Location = new Point(1090, 18);
        lblProximas.Name = "lblProximas";
        lblProximas.Size = new Size(116, 25);
        lblProximas.TabIndex = 4;
        lblProximas.Text = "\tPróximas: 0";
        // 
        // lblPersonas
        // 
        lblPersonas.AutoSize = true;
        lblPersonas.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblPersonas.ForeColor = Color.DarkGreen;
        lblPersonas.Location = new Point(845, 18);
        lblPersonas.Name = "lblPersonas";
        lblPersonas.Size = new Size(117, 25);
        lblPersonas.TabIndex = 3;
        lblPersonas.Text = " Personas: 0";
        lblPersonas.Click += lblPersonas_Click;
        // 
        // lblCulturales
        // 
        lblCulturales.AutoSize = true;
        lblCulturales.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblCulturales.ForeColor = Color.DarkGreen;
        lblCulturales.Location = new Point(631, 18);
        lblCulturales.Name = "lblCulturales";
        lblCulturales.Size = new Size(122, 25);
        lblCulturales.TabIndex = 2;
        lblCulturales.Text = "Culturales: 0";
        lblCulturales.Click += lblCulturales_Click;
        // 
        // lblAventura
        // 
        lblAventura.AutoSize = true;
        lblAventura.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblAventura.ForeColor = Color.DarkGreen;
        lblAventura.Location = new Point(370, 18);
        lblAventura.Name = "lblAventura";
        lblAventura.Size = new Size(115, 25);
        lblAventura.TabIndex = 1;
        lblAventura.Text = "\tAventura: 0";
        lblAventura.Click += lblAventura_Click;
        // 
        // lblIngresos
        // 
        lblIngresos.AutoSize = true;
        lblIngresos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblIngresos.ForeColor = Color.DarkGreen;
        lblIngresos.Location = new Point(17, 18);
        lblIngresos.Name = "lblIngresos";
        lblIngresos.Size = new Size(183, 25);
        lblIngresos.TabIndex = 0;
        lblIngresos.Text = "Ingresos totales: ₡0";
        // 
        // btnSalir
        // 
        btnSalir.BackColor = Color.Crimson;
        btnSalir.Location = new Point(1239, 760);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new Size(105, 45);
        btnSalir.TabIndex = 9;
        btnSalir.Text = "Salir";
        btnSalir.UseVisualStyleBackColor = false;
        btnSalir.Click += button2_Click;
        // 
        // dgvReservas
        // 
        dgvReservas.AllowUserToAddRows = false;
        dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvReservas.Columns.AddRange(new DataGridViewColumn[] { colCliente, colTipo, colTour, colFecha, colPersonas, colTotal, colEstado });
        dgvReservas.Location = new Point(12, 216);
        dgvReservas.MultiSelect = false;
        dgvReservas.Name = "dgvReservas";
        dgvReservas.ReadOnly = true;
        dgvReservas.RowHeadersVisible = false;
        dgvReservas.RowHeadersWidth = 51;
        dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvReservas.Size = new Size(1330, 235);
        dgvReservas.TabIndex = 2;
        // 
        // colCliente
        // 
        colCliente.DataPropertyName = "Cliente";
        colCliente.HeaderText = "Cliente";
        colCliente.MinimumWidth = 6;
        colCliente.Name = "colCliente";
        colCliente.ReadOnly = true;
        // 
        // colTipo
        // 
        colTipo.DataPropertyName = "Tipo";
        colTipo.HeaderText = "Tipo";
        colTipo.MinimumWidth = 6;
        colTipo.Name = "colTipo";
        colTipo.ReadOnly = true;
        // 
        // colTour
        // 
        colTour.DataPropertyName = "Tour";
        colTour.HeaderText = "Tour";
        colTour.MinimumWidth = 6;
        colTour.Name = "colTour";
        colTour.ReadOnly = true;
        // 
        // colFecha
        // 
        colFecha.DataPropertyName = "FechaTour";
        colFecha.HeaderText = "Fecha";
        colFecha.MinimumWidth = 6;
        colFecha.Name = "colFecha";
        colFecha.ReadOnly = true;
        // 
        // colPersonas
        // 
        colPersonas.DataPropertyName = "Personas";
        colPersonas.HeaderText = "Personas";
        colPersonas.MinimumWidth = 6;
        colPersonas.Name = "colPersonas";
        colPersonas.ReadOnly = true;
        // 
        // colTotal
        // 
        colTotal.DataPropertyName = "Total";
        dataGridViewCellStyle1.Format = "C2";
        dataGridViewCellStyle1.FormatProvider = new System.Globalization.CultureInfo("es-CR");
        colTotal.DefaultCellStyle = dataGridViewCellStyle1;
        colTotal.HeaderText = "Total";
        colTotal.MinimumWidth = 6;
        colTotal.Name = "colTotal";
        colTotal.ReadOnly = true;
        // 
        // colEstado
        // 
        colEstado.DataPropertyName = "Estado";
        colEstado.HeaderText = "Estado";
        colEstado.MinimumWidth = 6;
        colEstado.Name = "colEstado";
        colEstado.ReadOnly = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(13F, 30F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FloralWhite;
        BackgroundImage = Properties.Resources.imagen;
        ClientSize = new Size(1370, 749);
        Controls.Add(plnEncabezado);
        Controls.Add(btnSalir);
        Controls.Add(pnlResumen);
        Controls.Add(btnDetalle);
        Controls.Add(btnEliminar);
        Controls.Add(btnBuscarCliente);
        Controls.Add(btnNueva);
        Controls.Add(dgvReservas);
        Controls.Add(lblReservas);
        Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ForeColor = Color.White;
        HelpButton = true;
        Margin = new Padding(6);
        MinimumSize = new Size(1364, 718);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Brisa Caribe Tours";
        Load += Form1_Load;
        plnEncabezado.ResumeLayout(false);
        plnEncabezado.PerformLayout();
        pnlResumen.ResumeLayout(false);
        pnlResumen.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Panel plnEncabezado;
    private Label lblTitulo;
    private Label lblFecha;
    private Label lblReservas;
    private Button btnNueva;
    private Button btnBuscarCliente;
    private Button btnEliminar;
    private Button btnDetalle;
    private Panel pnlResumen;
    private Label lblIngresos;
    private Label lblPersonas;
    private Label lblCulturales;
    private Label lblAventura;
    private Label lblProximas;
    private Button btnSalir;
    private DataGridView dgvReservas;
    private DataGridViewTextBoxColumn colCliente;
    private DataGridViewTextBoxColumn colTipo;
    private DataGridViewTextBoxColumn colTour;
    private DataGridViewTextBoxColumn colFecha;
    private DataGridViewTextBoxColumn colPersonas;
    private DataGridViewTextBoxColumn colTotal;
    private DataGridViewTextBoxColumn colEstado;
}
