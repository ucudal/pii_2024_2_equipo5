using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Dragon;

public class PulsoDragon : iMovimiento
{
    public Tipos Tipos { get; } = Tipos.DRAGON;
        
    public string Nombre { get; } = "Pulso Dragon";
        
    public int Daño { get; } = 40;
        
    public int PP { get; } = 10;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = true;


    public PulsoDragon()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}