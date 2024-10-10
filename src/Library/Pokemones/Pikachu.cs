using Library.Enums;
using Library.Interfaces;
using Library.Movimientos.Electrico;
using Library.Movimientos.Normal;

namespace Library.Pokemones;

public class Pikachu : iPokemon
{
    public string Nombre { get; set; }
    public int SaludTotal { get; set; }
    public int SaludActual { get; set; }
    public int ValorAtaque { get; set; }
    public int ValorDefensa { get; set; }
    public int ValorAtaqueEspecial { get; set; }
    public int ValorDefensaEspecial { get; set; }
    public List<iMovimiento> Movimientos { get; set; }
    public List<Tipos> Tipo { get; set; }

    
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

        Movimientos = new List<iMovimiento>{ new Impactrueno(), new AtaqueRapido(), new Rayo(), new BolaVoltio() };
        Tipo = new List<Tipos> { Tipos.ELECTRICO };

    }

    public void RecibirDanio(int danio)
    {
        SaludActual = Math.Max(SaludActual - danio, 0);
        if (SaludActual <= 0)        {
            Debil = true;
        }
    }

    public bool Debil { get; set; }

    public void UsarMovimiento(iMovimiento movimiento)
    {
        iMovimiento MovimientoUtilizado = Movimientos.Find(f => f == movimiento);

        if (MovimientoUtilizado != null)
        {
            MovimientoUtilizado.CurrentPP -= 1;
            
        }                                           // Restamos 1 PP, ya que al usarlo se gasta.
    }
}