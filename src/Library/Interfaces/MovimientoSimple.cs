using Library.Enums;

namespace Library.Interfaces;

public class MovimientoSimple: IMovimiento
{
    protected ETipos tipo;
    protected string nombre;
    protected int daño;
    protected int pP;
    protected int currentPP;
    protected bool especial = false;

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
    
    
    
}