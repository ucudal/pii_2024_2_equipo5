namespace DefaultNamespace;

public class Vivillion: iPokemon
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

    
    public Vivillion()
    {
        Nombre = "Vivillion";
        
        SaludTotal = 109;
        SaludActual = SaludTotal;

        ValorAtaque = 55;
        ValorDefensa = 40;
        ValorAtaqueEspecial = 60;
        ValorDefensaEspecial = 55;
        Debil = false;

        Movimientos = new List<iMovimiento>{ new Zumbido(), new Placaje(), new TijeraX(), new Psicoonda() };
        Tipo = new List<Tipos> { Tipos.BICHO, Tipos.VOLADOR };

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