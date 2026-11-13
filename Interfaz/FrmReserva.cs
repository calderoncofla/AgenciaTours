using AgenciaTours.Logica;

namespace AgenciaTours.Interfaz;

/// <summary>
/// Ventana para capturar y validar los datos de una reserva.
/// </summary>
public partial class FrmReserva : Form
{
    // Objeto que permite consultar los datos de los tours.
    private readonly CatalogoTours catalogo = new CatalogoTours();

    // Reserva que se devolverá a la ventana principal al aceptar.
    public Reserva ReservaCreada { get; private set; } = null!;

    public FrmReserva()
    {
        InitializeComponent();
    }

    private void FrmReserva_Load(object sender, EventArgs e)
    {
        // Carga los seis tours del catálogo.
        lstTours.Items.Clear();

        for (int i = 0; i < 6; i++)
        {
            lstTours.Items.Add(catalogo.ObtenerNombre(i));
        }

        // Carga los idiomas disponibles para el guía.
        lstIdioma.Items.Clear();
        lstIdioma.Items.Add("Español");
        lstIdioma.Items.Add("Inglés");

        // El idioma se habilita al elegir un tour cultural.
        lstIdioma.Enabled = false;
    }

    private void lstTours_SelectedIndexChanged(object sender, EventArgs e)
    {
        int indice = lstTours.SelectedIndex;

        // No hace nada si aún no se seleccionó un tour.
        if (indice < 0)
            return;

        // Muestra los datos del tour seleccionado.
        string tipo = catalogo.ObtenerTipo(indice);

        lblTipo.Text = "Tipo: " + tipo;
        lblPrecio.Text = $"Precio: {catalogo.ObtenerPrecio(indice):C0}";
        lblDificultad.Text =
            "Dificultad: " + catalogo.ObtenerDificultad(indice);

        // Solo los tours culturales permiten elegir idioma.
        bool esCultural = tipo == "Cultural";
        lstIdioma.Enabled = esCultural;

        if (!esCultural)
        {
            lstIdioma.SelectedIndex = -1;
        }
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
        errorProvider1.Clear();

        // Comprueba que se haya escrito el nombre del cliente.
        if (string.IsNullOrWhiteSpace(txtCliente.Text))
        {
            errorProvider1.SetError(
                txtCliente, "Escriba el nombre del cliente.");
            return;
        }

        // Comprueba que se haya seleccionado un tour.
        int indice = lstTours.SelectedIndex;

        if (indice < 0)
        {
            errorProvider1.SetError(lstTours, "Seleccione un tour.");
            return;
        }

        // Comprueba que la cantidad sea un número entre 1 y 20.
        if (!int.TryParse(txtPersonas.Text, out int personas) ||
            personas < 1 || personas > 20)
        {
            errorProvider1.SetError(
                txtPersonas, "Escriba una cantidad de 1 a 20.");
            return;
        }

        // Comprueba que la fecha no haya pasado.
        DateTime fecha = dtpFechaTour.Value.Date;

        if (fecha < DateTime.Today)
        {
            errorProvider1.SetError(
                dtpFechaTour, "Seleccione una fecha de hoy en adelante.");
            return;
        }

        string nombreTour = catalogo.ObtenerNombre(indice);
        string tipo = catalogo.ObtenerTipo(indice);
        decimal precio = catalogo.ObtenerPrecio(indice);

        // Crea la reserva según el tipo de tour.
        if (tipo == "Cultural")
        {
            if (lstIdioma.SelectedItem == null)
            {
                errorProvider1.SetError(
                    lstIdioma, "Seleccione el idioma del guía.");
                return;
            }

            string idioma = lstIdioma.SelectedItem.ToString()!;

            ReservaCreada = new ReservaCultural(
                txtCliente.Text.Trim(),
                nombreTour,
                precio,
                personas,
                fecha,
                idioma);
        }
        else
        {
            string dificultad = catalogo.ObtenerDificultad(indice);

            ReservaCreada = new ReservaAventura(
                txtCliente.Text.Trim(),
                nombreTour,
                precio,
                personas,
                fecha,
                dificultad);
        }

        // Devuelve el resultado correcto a la ventana principal.
        DialogResult = DialogResult.OK;
    }

    private void dtpFechaTour_ValueChanged(object sender, EventArgs e)
    {
        // Aquí se pueden agregar validaciones de fecha si hacen falta.
    }

    private void lstIdioma_SelectedIndexChanged(object sender, EventArgs e)
    {
        // La selección se utiliza al aceptar la reserva.
    }
}