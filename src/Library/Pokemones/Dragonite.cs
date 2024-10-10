using Library.Enums;
using Library.Interfaces;
using Library.Movimientos.Dragon;
using Library.Movimientos.Normal;
using Library.Movimientos.Volador;

namespace Library.Pokemones;

public class Dragonite : IPokemon
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

    
    public Dragonite()
    {
        Nombre = "Dragonite";
        
        SaludTotal = 125;
        SaludActual = SaludTotal;

        ValorAtaque = 55;
        ValorDefensa = 45;
        ValorAtaqueEspecial = 63;
        ValorDefensaEspecial = 55;
        Debil = false;

        Movimientos = new List<IMovimiento>{ new Corte(), new Vuelo(), new GarraDragon(), new PulsoDragon() };
        Tipo = new List<ETipos> { ETipos.DRAGON, ETipos.VOLADOR };

    }

    public void RecibirDanio(int danio)
    {
        SaludActual = Math.Max(SaludActual - danio, 0);
        if (SaludActual <= 0)        {
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
            
        }                                           // Restamos 1 PP, ya que al usarlo se gasta.
    }
}