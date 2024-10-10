using Library.Enums;
using Library.Interfaces;
using Library.Movimientos.Hada;
using Library.Movimientos.Normal;

namespace Library.Pokemones;

public class Sylveon
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

    
    public Sylveon()
    {
        Nombre = "Sylveon";
        
        SaludTotal = 115;
        SaludActual = SaludTotal;

        ValorAtaque = 59;
        ValorDefensa = 43;
        ValorAtaqueEspecial = 63;
        ValorDefensaEspecial = 49;
        Debil = false;

        Movimientos = new List<iMovimiento>{ new FuerzaLunar(), new AtaqueRapido(), new Placaje() };
        Tipo = new List<Tipos> { Tipos.HADA };

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