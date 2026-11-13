using AgenciaTours.Logica;

using System.Linq;

namespace AgenciaTours.Interfaz;

/// <summary>
/// Ventana principal para administrar las reservas.
/// </summary>
public partial class Form1 : Form
{

    private void lblPersonas_Click(object sender, EventArgs e)
    {
        // Evento del Label Personas.
    }

    // Administra las reservas de la aplicación.
    private readonly GestorReservas gestor = new GestorReservas();

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // Muestra la fecha actual.
        lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

        // Carga la tabla y el resumen al abrir la ventana.
        CargarReservas();
    }

    private void CargarReservas()
    {
        // Colores de las filas.
        dgvReservas.DefaultCellStyle.ForeColor = Color.Black;
        dgvReservas.DefaultCellStyle.SelectionForeColor = Color.White;
        dgvReservas.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;

        // Aumentar la altura de cada fila.
        dgvReservas.RowTemplate.Height = 55;

        dgvReservas.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.AllCells;

        // Ajustar las columnas al espacio disponible.
        dgvReservas.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

        // Permitir que se muestre todo el texto.
        dgvReservas.DefaultCellStyle.WrapMode =
            DataGridViewTriState.True;

        // Encabezados más grandes.
        dgvReservas.ColumnHeadersHeightSizeMode =
            DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

        dgvReservas.ColumnHeadersHeight = 45;

        // Mejorar la apariencia del texto.
        dgvReservas.DefaultCellStyle.Font =
            new Font("Segoe UI", 12, FontStyle.Regular);

        dgvReservas.ColumnHeadersDefaultCellStyle.Font =
            new Font("Segoe UI", 12, FontStyle.Bold);

        // Mantener la configuración de las columnas.
        dgvReservas.AutoGenerateColumns = false;

        // Actualizar las reservas.
        dgvReservas.DataSource = null;
        dgvReservas.DataSource = gestor.ObtenerTodas();

        // Mostrar los montos en colones con dos decimales.
        if (dgvReservas.Columns.Contains("Total"))
        {
            dgvReservas.Columns["Total"].DefaultCellStyle.Format = "C2";
            dgvReservas.Columns["Total"].DefaultCellStyle.FormatProvider =
                new System.Globalization.CultureInfo("es-CR");
        }
        // Actualizar ingresos y estadísticas.
        ActualizarResumen();
    }


    // Actualiza los ingresos, las cantidades y las próximas reservas.
    private void ActualizarResumen()
    {
        lblIngresos.Text =
            $"Ingresos totales: {gestor.CalcularIngresos():C0}";

        lblAventura.Text =
            $"Aventura: {gestor.ContarAventura()}";

        lblCulturales.Text =
            $"Culturales: {gestor.ContarCultural()}";

        lblPersonas.Text =
            $"Personas: {gestor.ContarPersonas()}";

        lblProximas.Text =
            $"Próximas: {gestor.ContarProximas()}";
    }

    private void btnNueva_Click(object sender, EventArgs e)
    {
        // Abre la ventana para capturar una reserva.
        using FrmReserva formulario = new FrmReserva();

        if (formulario.ShowDialog(this) != DialogResult.OK)
            return;

        Reserva reservaNueva = formulario.ReservaCreada;

        // Revisa los espacios disponibles para el tour y la fecha.
        int disponibles = gestor.CuposDisponibles(
            reservaNueva.Tour,
            reservaNueva.FechaTour);

        if (reservaNueva.Personas > disponibles)
        {
            MessageBox.Show(
                $"Solo quedan {disponibles} espacios para ese tour y fecha.",
                "Cupos disponibles",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

            return;
        }

        // Guarda la reserva y refresca la pantalla.
        gestor.Agregar(reservaNueva);
        CargarReservas();
    }

    private void plnEncabezado_Paint(object sender, PaintEventArgs e)
    {
        // Evento de dibujo del encabezado.
    }


    private void btnResumen_Click(object sender, EventArgs e)
    {
        // Verificar que exista una reserva seleccionada.
        if (dgvReservas.CurrentRow?.DataBoundItem is not Reserva reserva)
        {
            MessageBox.Show(
                "Primero seleccioná una reserva de la tabla.",
                "Ver detalle",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;
        }

        // Mostrar la información de la reserva.
        string detalle =
            "BRISA CARIBE TOURS\n" +
            "DETALLE DE LA RESERVA\n" +
            "------------------------------------\n\n" +
            $"Cliente: {reserva.Cliente}\n" +
            $"Tour: {reserva.Tour}\n" +
            $"Tipo: {reserva.Tipo}\n" +
            $"Fecha: {reserva.FechaTour:dd/MM/yyyy}\n" +
            $"Personas: {reserva.Personas}\n" +
            $"Estado: {reserva.Estado}\n\n" +
            $"Total a pagar: ₡{reserva.Total:N2}";

        MessageBox.Show(
            this,
            detalle,
            "Detalle de reserva - Brisa Caribe Tours",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }


    private void btnEliminar_Click(object sender, EventArgs e)
    {
        // Obtener la reserva de la fila seleccionada.
        if (dgvReservas.CurrentRow?.DataBoundItem is not Reserva reserva)
        {
            MessageBox.Show(
                "Seleccioná la reserva que querés eliminar.",
                "Eliminar reserva",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return;
        }

        // Confirmar mostrando cuál reserva se eliminará.
        DialogResult respuesta = MessageBox.Show(
            this,
            $"¿Querés eliminar esta reserva?\n\n" +
            $"Cliente: {reserva.Cliente}\n" +
            $"Tour: {reserva.Tour}\n" +
            $"Fecha: {reserva.FechaTour:dd/MM/yyyy}\n" +
            $"Personas: {reserva.Personas}",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);

        if (respuesta != DialogResult.Yes)
            return;

        if (gestor.Eliminar(reserva))
        {
            // Actualizar la tabla completa y el resumen.
            CargarReservas();
        }
        else
        {
            MessageBox.Show(
                "No se encontró la reserva para eliminar.",
                "Eliminar reserva",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        string nombre = Microsoft.VisualBasic.Interaction.InputBox(
            "Escribí el nombre del cliente o una parte.\n\n" +
            "Dejá el espacio vacío para mostrar todas las reservas.",
            "Buscar cliente",
            "").Trim();

        // Mostrar todas las reservas si no se escribió un nombre.
        if (string.IsNullOrWhiteSpace(nombre))
        {
            CargarReservas();
            return;
        }

        // Buscar sin distinguir mayúsculas y minúsculas.
        var resultados = gestor.ObtenerTodas()
            .Where(reserva =>
                reserva.Cliente != null &&
                reserva.Cliente.Contains(
                    nombre,
                    StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (resultados.Count == 0)
        {
            MessageBox.Show(
                $"No se encontraron reservas para \"{nombre}\".",
                "Buscar cliente",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarReservas();
            return;
        }

        // Mostrar las reservas encontradas.
        dgvReservas.DataSource = null;
        dgvReservas.DataSource = resultados;
    }
    private void lblAventura_Click(object sender, EventArgs e)
    {

    }

    private void lblCulturales_Click(object sender, EventArgs e)
    {

    }

    private void pnlResumen_Paint(object sender, PaintEventArgs e)
    {

    }
}