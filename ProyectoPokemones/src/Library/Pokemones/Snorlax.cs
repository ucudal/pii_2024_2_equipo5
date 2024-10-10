namespace DefaultNamespace;

public class Snorlax: iPokemon
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

    
    public Snorlax()
    {
        Nombre = "Snorlax";
        
        SaludTotal = 150;
        SaludActual = SaludTotal;

        ValorAtaque = 30;
        ValorDefensa = 75;
        ValorAtaqueEspecial = 35;
        ValorDefensaEspecial = 75;
        Debil = false;

        Movimientos = new List<iMovimiento>{ new Placaje() };
        Tipo = new List<Tipos> { Tipos.NORMAL };

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