using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Dragon;

public class GarraDragon : IMovimiento
{
    public ETipos Tipo { get; } = ETipos.DRAGON;
        
    public string Nombre { get; } = "Garra Dragon";
        
    public int Daño { get; } = 45;
        
    public int PP { get; } = 10;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = false;


    public GarraDragon()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}