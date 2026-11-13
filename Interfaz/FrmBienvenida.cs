using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgenciaTours.Interfaz
{
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }

        private void FrmBienvenida_Load(object sender, EventArgs e)
        {

        }

        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            Hide();

            try
            {
                using Form1 ventana = new Form1();
                ventana.ShowDialog();
            }
            finally
            {
                Show();
            }
        }
    }
}
