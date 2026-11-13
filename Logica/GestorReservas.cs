using System.Collections.Generic;
namespace AgenciaTours.Logica;

/// <summary>Administra la lista privada de reservas y sus resúmenes.</summary>
public class GestorReservas
{
    // TODO: agregar la lista privada y los métodos pedidos en la sección 6 del PDF.

    // Lista privada: solo GestorReservas administra las reservas.
    private List<Reserva> reservas = new List<Reserva>();

    // Cuenta las personas ya reservadas para ese tour y esa fecha.
    public int CuposDisponibles(string tour, DateTime fecha)
    {
        int ocupados = 0;

        foreach (Reserva reserva in reservas)
        {
            if (reserva.Tour == tour && reserva.FechaTour.Date == fecha.Date)
                ocupados += reserva.Personas;
        }

        return 20 - ocupados;
    }

    // Agrega la reserva solo si el tour todavía tiene espacio.
    public bool Agregar(Reserva r)
    {
        int disponibles = CuposDisponibles(r.Tour, r.FechaTour);

        if (r.Personas > disponibles)
            return false;

        reservas.Add(r);
        return true;
    }

    // Devuelve una copia para que otras clases no modifiquen la lista privada.
    public List<Reserva> ObtenerTodas()
    {
        return new List<Reserva>(reservas);
    }

    // Elimina una reserva solo si la posición existe.
    public void Eliminar(int indice)
    {
        if (indice >= 0 && indice < reservas.Count)
            reservas.RemoveAt(indice);
    }

    // Elimina exactamente la reserva seleccionada.
    public bool Eliminar(Reserva reserva)
    {
        return reservas.Remove(reserva);
    }

    // Suma el total de todas las reservas.
    public decimal CalcularIngresos()
    {
        decimal ingresos = 0;

        foreach (Reserva reserva in reservas)
            ingresos += reserva.Total;

        return ingresos;
    }

    // Cuenta las reservas de aventura.
    public int ContarAventura()
    {
        int cantidad = 0;

        foreach (Reserva reserva in reservas)
        {
            if (reserva is ReservaAventura)
                cantidad++;
        }

        return cantidad;
    }

    // Cuenta las reservas culturales.
    public int ContarCultural()
    {
        int cantidad = 0;

        foreach (Reserva reserva in reservas)
        {
            if (reserva is ReservaCultural)
                cantidad++;
        }

        return cantidad;
    }

    // Suma todas las personas incluidas en las reservas.
    public int ContarPersonas()
    {
        int totalPersonas = 0;

        foreach (Reserva reserva in reservas)
            totalPersonas += reserva.Personas;

        return totalPersonas;
    }

    // Cuenta los tours de hoy y los que ocurren en los próximos siete días.
    public int ContarProximas()
    {
        int cantidad = 0;

        foreach (Reserva reserva in reservas)
        {
            if (reserva.Estado == "Hoy" || reserva.Estado == "Próximo")
                cantidad++;
        }

        return cantidad;
    }
}
