namespace AgenciaTours.Interfaz
{
    partial class FrmBienvenida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lbiDescripción = new Label();
            btnReservaciones = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(164, 72);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(502, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "\tBIENVENIDOS A BRISA CARIBE TOURS";
            // 
            // lbiDescripción
            // 
            lbiDescripción.AutoSize = true;
            lbiDescripción.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbiDescripción.ForeColor = Color.White;
            lbiDescripción.Location = new Point(129, 221);
            lbiDescripción.Name = "lbiDescripción";
            lbiDescripción.Size = new Size(629, 32);
            lbiDescripción.TabIndex = 1;
            lbiDescripción.Text = "Descubrí Costa Rica y viví una experiencia inolvidable";
            // 
            // btnReservaciones
            // 
            btnReservaciones.BackColor = Color.Turquoise;
            btnReservaciones.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservaciones.Location = new Point(295, 330);
            btnReservaciones.Name = "btnReservaciones";
            btnReservaciones.Size = new Size(280, 60);
            btnReservaciones.TabIndex = 2;
            btnReservaciones.Text = "Reservaciones";
            btnReservaciones.UseVisualStyleBackColor = false;
            btnReservaciones.Click += btnReservaciones_Click;
            // 
            // FrmBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            BackgroundImage = Properties.Resources.Costa_Caribe_con_selva_y_mar_turquesa;
            ClientSize = new Size(856, 526);
            Controls.Add(btnReservaciones);
            Controls.Add(lbiDescripción);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmBienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\tBrisa Caribe Tours — Bienvenidos";
            Load += FrmBienvenida_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lbiDescripción;
        private Button btnReservaciones;
    }
}