namespace DefaultNamespace;

public class Charizard: iPokemon
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

    
    public Charizard()
    {
        Nombre = "Charizard";
        
        SaludTotal = 130;
        SaludActual = SaludTotal;

        ValorAtaque = 58;
        ValorDefensa = 43;
        ValorAtaqueEspecial = 65;
        ValorDefensaEspecial = 50;
        Debil = false;

        Movimientos = new List<iMovimiento>{ new Lanzallamas(), new Vuelo(), new GarraDragon(), new PulsoDragon() };
        Tipo = new List<Tipos> { Tipos.FUEGO, Tipos.VOLADOR };

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

    public void UsarMovimiento(iMovimiento movimiento)
    {
        iMovimiento MovimientoUtilizado = Movimientos.Find(f => f == movimiento);

        if (MovimientoUtilizado != null)
        {
            MovimientoUtilizado.CurrentPP -= 1;
            
        }                                           // Restamos 1 PP, ya que al usarlo se gasta.
    }
}