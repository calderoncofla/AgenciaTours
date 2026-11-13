namespace AgenciaTours.Logica;

/// <summary>Reserva de aventura. Implementar herencia y cargo del seguro.</summary>
public class ReservaAventura : Reserva
{
    // TODO: agregar Dificultad, constructor, Tipo override y Cargo override.

    // Guarda la dificultad definida para el tour.
    public string Dificultad { get; set; } = "Media";

    // Crea la reserva de aventura y envía los datos comunes a Reserva.
    public ReservaAventura(string cliente, string tour, decimal precioPorPersona,
        int personas, DateTime fechaTour, string dificultad)
        : base(cliente, tour, precioPorPersona, personas, fechaTour)
    {
        Dificultad = dificultad;
    }

    // Reemplaza el tipo general por Aventura.
    public override string Tipo
    {
        get { return "Aventura"; }
    }

    // Calcula el seguro obligatorio de ₡3 000 por persona.
    public override decimal Cargo
    {
        get { return 3000m * Personas; }
    }


}
