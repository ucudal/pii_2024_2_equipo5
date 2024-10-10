using Library.Enums;
using Library.Interfaces;

namespace Library.Pokemones;

public class Venasaur
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

    
    public Venasaur()
    {
        Nombre = "Venasaur";
        
        SaludTotal = 130;
        SaludActual = SaludTotal;

        ValorAtaque = 50;
        ValorDefensa = 55;
        ValorAtaqueEspecial = 50;
        ValorDefensaEspecial = 60;
        Debil = false;

        Movimientos = new List<iMovimiento>{ new LatigoCepa(), new HojaMagica(), new CargaToxica(), new Placaje() };
        Tipo = new List<Tipos> { Tipos.PLANTA, Tipos.VENENO };

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