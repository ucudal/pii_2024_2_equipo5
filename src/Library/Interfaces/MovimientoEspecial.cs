using Library.Enums;

namespace Library.Interfaces;

public class MovimientoEspecial: IMovimiento
{
    protected ETipos tipo;
    protected string nombre;
    protected int daño;
    protected int pP = 4;
    protected int currentPP;
    protected bool especial = true;
    public EEstado efecto;
    public double precision;

    public EEstado Efecto
    {
        get => efecto;
        set => efecto = value;
    }

    public double Precision
    {
        get => precision;
        set => precision = value;
    }

    public bool Especial
    {
        get => especial;
    }

    public ETipos Tipo
    {
        get => tipo;
        set => tipo = value;
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Daño
    {
        get => daño;
        set => daño = value;
    }

    public int PP
    {
        get => pP;
        set => pP = value;
    }

    public int CurrentPP
    {
        get => currentPP;
        set => currentPP = value;
    }
    
    public bool AplicarEfecto(IPokemon victima)
    {
        // Lanza un número aleatorio para determinar si aplica el efecto
        Random rand = new Random();
        bool acierto = rand.NextDouble() <= Precision; // se compara el número aleatorio generado con la precisión del ataque.
                                                       // Si el número aleatorio es menor o igual a la precisión,
                                                       // se considera que el ataque fue exitoso (acierto). 

        if (acierto && victima.Estado == EEstado.NORMAL) // Sólo aplica si el Pokémon está en estado normal
        {
            victima.Estado = Efecto;

            // Si el efecto es Dormido, determina cuántos turnos estará dormido (1 a 4) (el resto de estados se gestionan en batalla)
            if (Efecto == EEstado.DORMIDO)
            {
                victima.TurnosDormido = rand.Next(1, 5);
            }

            return true; // Efecto aplicado
        }

        return false; // No se aplicó el efecto
    }

}