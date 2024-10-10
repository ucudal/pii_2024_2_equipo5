using Library.Enums;
using Library.Interfaces;
using Library.Movimientos.Agua;
using Library.Movimientos.Normal;

namespace Library.Pokemones;

public class Blastoise: iPokemon
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
    public bool Debil { get; set; }

    
    public Blastoise()
    {
        Nombre = "Blastoise";
        
        SaludTotal = 135;
        SaludActual = SaludTotal;

        ValorAtaque = 55;
        ValorDefensa = 45;
        ValorAtaqueEspecial = 60;
        ValorDefensaEspecial = 50;
        Debil = false;

        Movimientos = new List<iMovimiento>{ new Hidrobomba(), new Hidropulso(), new Burbuja(), new Placaje() };
        Tipo = new List<Tipos> { Tipos.AGUA };

    }

    public void RecibirDanio(int danio)
    {
        SaludActual = Math.Max(SaludActual - danio, 0);
        if (SaludActual <= 0)        {
            Debil = true;
        }
    }


    public void UsarMovimiento(iMovimiento movimiento)
    {
        iMovimiento MovimientoUtilizado = Movimientos.Find(f => f == movimiento);

        if (MovimientoUtilizado != null)
        {
            MovimientoUtilizado.CurrentPP -= 1;
            
        }                                           // Restamos 1 PP, ya que al usarlo se gasta.
    }
}