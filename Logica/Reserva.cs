namespace AgenciaTours.Logica; // Organiza esta clase dentro de la lógica del proyecto.

/// <summary>
/// Representa una reserva general de un tour.
/// Es la clase base de las reservas de aventura y culturales.
/// </summary>
public class Reserva
{
    // Guarda el nombre de la persona que hizo la reserva.
    public string Cliente { get; set; } = "";

    // Guarda el nombre del tour reservado.
    public string Tour { get; set; } = "";

    // Campo privado donde se conserva el precio.
    private decimal precioPorPersona;

    // El precio solo cambia si es cero o mayor.
    public decimal PrecioPorPersona
    {
        get { return precioPorPersona; }
        set
        {
            if (value >= 0)
                precioPorPersona = value;
        }
    }

    // Conserva la cantidad de personas de la reserva.
    private int personas = 1;

    // Fecha en que se realizará el tour.
    public DateTime FechaTour { get; set; }

    // Fecha en que se creó la reserva; solo la clase puede cambiarla.
    public DateTime FechaRegistro { get; private set; }

    // Solo permite cantidades entre 1 y 20.
    public int Personas
    {
        get { return personas; }
        set
        {
            if (value >= 1 && value <= 20)
                personas = value;
        }

    }

    // Recibe los datos iniciales y registra cuándo se creó la reserva.
    public Reserva(string cliente, string tour, decimal precioPorPersona,
        int personas, DateTime fechaTour)
    {
        Cliente = cliente;
        Tour = tour;
        PrecioPorPersona = precioPorPersona;
        Personas = personas;
        FechaTour = fechaTour;
        FechaRegistro = DateTime.Now;
    }

    // Indica el tipo de reserva; las clases hijas podrán cambiar este valor.
    public virtual string Tipo
    {
        get { return "General"; }
    }

    // Calcula el precio base multiplicando precio por cantidad de personas.
    public decimal Subtotal
    {
        get { return PrecioPorPersona * Personas; }
    }

    // Calcula cuántos días pasaron entre el registro y la fecha del tour.
    public int DiasAnticipacion
    {
        get { return (FechaTour.Date - FechaRegistro.Date).Days; }
    }

    // Calcula cuántos días faltan desde hoy hasta el tour.
    public int DiasParaTour
    {
        get { return (FechaTour.Date - DateTime.Today).Days; }
    }

    // Define el estado usando los días que faltan para el tour.
    public string Estado
    {
        get
        {
            if (DiasParaTour < 0)
                return "Realizado";

            if (DiasParaTour == 0)
                return "Hoy";

            if (DiasParaTour <= 7)
                return "Próximo";

            return "Programado";
        }
    }

    // Aplica un único descuento: primero revisa si es un grupo de 6 o más.
    public decimal Descuento
    {
        get
        {
            if (Personas >= 6)
                return Subtotal * 0.10m;

            if (DiasAnticipacion >= 30)
                return Subtotal * 0.05m;

            return 0;
        }
    }

    // Una reserva general no tiene cargos adicionales.
    // Las clases hijas pueden reemplazar este cálculo.
    public virtual decimal Cargo
    {
        get { return 0; }
    }

    // Calcula el IVA del 13 % sobre el monto con descuento y cargo.
    public decimal Iva
    {
        get { return (Subtotal - Descuento + Cargo) * 0.13m; }
    }

    // Calcula el monto final que debe pagar el cliente.
    public decimal Total
    {
        get { return Subtotal - Descuento + Cargo + Iva; }
    }

}

