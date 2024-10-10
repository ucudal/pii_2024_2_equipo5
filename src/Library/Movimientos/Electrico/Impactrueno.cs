using Library.Enums;

namespace Library.Movimientos.Electrico;

public class Impactrueno
{
    public Tipos Tipos { get; } = Tipos.ELECTRICO;
        
    public string Nombre { get; } = "Impactrueno";
        
    public int Daño { get; } = 25;
        
    public int PP { get; } = 10;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = true;


    public Impactrueno()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}