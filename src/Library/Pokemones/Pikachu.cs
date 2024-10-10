using Library.Enums;
using Library.Interfaces;
using Library.Movimientos.Electrico;
using Library.Movimientos.Normal;

namespace Library.Pokemones;

public class Pikachu : IPokemon
{
    public string Nombre { get; set; }
    public int SaludTotal { get; set; }
    public int SaludActual { get; set; }
    public int ValorAtaque { get; set; }
    public int ValorDefensa { get; set; }
    public int ValorAtaqueEspecial { get; set; }
    public int ValorDefensaEspecial { get; set; }
    public List<IMovimiento> Movimientos { get; set; }
    public List<ETipos> Tipo { get; set; }


    public Pikachu()
    {
        Nombre = "Pikachu";

        SaludTotal = 100;
        SaludActual = SaludTotal;

        ValorAtaque = 50;
        ValorDefensa = 35;
        ValorAtaqueEspecial = 55;
        ValorDefensaEspecial = 35;
        Debil = false;

        Movimientos = new List<IMovimiento> { new Impactrueno(), new AtaqueRapido(), new Rayo(), new BolaVoltio() };
        Tipo = new List<ETipos> { ETipos.ELECTRICO, ETipos.NORMAL };
    }

    public void RecibirDanio(int danio)
    {
        SaludActual = Math.Max(SaludActual - danio, 0);
        if (SaludActual <= 0)
        {
            Debil = true;
        }
    }

    public bool Debil { get; set; }

    public void UsarMovimiento(IMovimiento movimiento)
    {
        IMovimiento MovimientoUtilizado = Movimientos.Find(f => f == movimiento);

        if (MovimientoUtilizado != null)
        {
            MovimientoUtilizado.CurrentPP -= 1;
        } // Restamos 1 PP, ya que al usarlo se gasta.
    }
}