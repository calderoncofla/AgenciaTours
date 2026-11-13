namespace AgenciaTours.Logica;

/// <summary>Catálogo de los seis tours. Los precios y tipos se toman del enunciado.</summary>
public class CatalogoTours
{
    // TODO: agregar los métodos de catálogo usando switch sobre la posición del tour.

    // Devuelve el nombre de la agencia según la posición del tour.
    public string ObtenerNombre(int indice)
    {

        switch (indice)
        {
            case 0: return "Canopy Brisa sobre Monteverde";
            case 1: return "Rafting Aventura del Pacuare";
            case 2: return "Sendero al Volcán Arenal";
            case 3: return "Ruta de Aromas del Café";
            case 4: return "Chocolate y cultura bribri";
            case 5: return "Teatro y museos de San José";
            default: return "Tour no válido";
        }
    }

    // Devuelve el tipo de tour correspondiente a su posición.
    public string ObtenerTipo(int indice)
    {
        switch (indice)
        {
            case 0:
            case 1:
            case 2:
                return "Aventura";

            case 3:
            case 4:
            case 5:
                return "Cultural";

            default:
                return "No válido";
        }
    }

    // Devuelve el precio por persona según la posición del tour.
    public decimal ObtenerPrecio(int indice)
    {
        switch (indice)
        {
            case 0: return 35000m;
            case 1: return 55000m;
            case 2: return 28000m;
            case 3: return 24000m;
            case 4: return 30000m;
            case 5: return 18000m;
            default: return 0m;
        }
    }

    // Devuelve la dificultad; los tours culturales no tienen dificultad.
    public string ObtenerDificultad(int indice)
    {
        switch (indice)
        {
            case 0: return "Media";
            case 1: return "Alta";
            case 2: return "Baja";
            case 3:
            case 4:
            case 5:
                return "—";
            default:
                return "No válida";
        }
    }
}

