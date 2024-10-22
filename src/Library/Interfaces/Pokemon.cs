using Library.Enums;

namespace Library.Interfaces;
//hay que cambiarla de lugar, está acá para que no se me pierda
public class Pokemon : IPokemon
{
    protected string nombre;
    protected int saludTotal;
    protected int saludActual;
    protected bool debil;
    protected int valorAtaque;
    protected int valorDefensa;
    protected int valorAtaqueEspecial;
    protected int valorDefensaEspecial;
    protected List<ETipos> tipo;
    protected List<IMovimiento> movimientos;

    public string Nombre
    {
        get => nombre;
        set => nombre = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int SaludTotal
    {
        get => saludTotal;
        set => saludTotal = value;
    }

    public int SaludActual
    {
        get => saludActual;
        set => saludActual = value;
    }

    public bool Debil
    {
        get => debil;
        set => debil = value;
    }

    public int ValorAtaque
    {
        get => valorAtaque;
        set => valorAtaque = value;
    }

    public int ValorDefensa
    {
        get => valorDefensa;
        set => valorDefensa = value;
    }

    public int ValorAtaqueEspecial
    {
        get => valorAtaqueEspecial;
        set => valorAtaqueEspecial = value;
    }

    public int ValorDefensaEspecial
    {
        get => valorDefensaEspecial;
        set => valorDefensaEspecial = value;
    }

    public List<ETipos> Tipo
    {
        get => tipo;
        set => tipo = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<IMovimiento> Movimientos
    {
        get => movimientos;
        set => movimientos = value ?? throw new ArgumentNullException(nameof(value));
    }


    public void RecibirDanio(int dañoRecibido)
    {
        SaludActual = Math.Max(SaludActual - dañoRecibido, 0);
        if (SaludActual <= 0)
        {
            Debil = true;
        }
    }

    public void UsarMovimiento(IMovimiento movimiento)
    {
        IMovimiento MovimientoUtilizado = Movimientos.Find(f => f == movimiento);

        if (MovimientoUtilizado != null)
        {
            MovimientoUtilizado.CurrentPP -= 1;
        } // Restamos 1 PP, ya que al usarlo se gasta.
    }
}