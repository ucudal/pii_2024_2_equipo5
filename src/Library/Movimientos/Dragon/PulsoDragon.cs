using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Dragon;

public class PulsoDragon : IMovimiento
{
    public ETipos Tipo { get; } = ETipos.DRAGON;
        
    public string Nombre { get; } = "Pulso Dragon";
        
    public int Daño { get; } = 40;
        
    public int PP { get; } = 4;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = true;


    public PulsoDragon()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}