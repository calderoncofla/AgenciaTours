namespace AgenciaTours.Logica;

/// <summary>Reserva cultural. Implementar idioma del guía y su cargo cuando corresponda.</summary>
public class ReservaCultural : Reserva
{
    // TODO: agregar IdiomaGuia, constructor, Tipo override y Cargo override.

    // Guarda el idioma elegido para el guía.
    public string IdiomaGuia { get; set; } = "Español";

    // Crea la reserva cultural y envía a la clase base sus datos comunes.
    public ReservaCultural(string cliente, string tour, decimal precioPorPersona,
        int personas, DateTime fechaTour, string idiomaGuia)
        : base(cliente, tour, precioPorPersona, personas, fechaTour)
    {
        IdiomaGuia = idiomaGuia;
    }

    // Indica que esta reserva pertenece a un tour cultural.
    public override string Tipo
    {
        get { return "Cultural"; }
    }

    // Guía en inglés: ₡2 500 por persona; en español no se cobra.
    public override decimal Cargo
    {
        get
        {
            if (IdiomaGuia == "Inglés")
                return 2500m * Personas;

            return 0;
        }
    }
}