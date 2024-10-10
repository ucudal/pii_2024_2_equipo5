using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Bicho;

public class TijeraX: IMovimiento
{
    public ETipos ETipos { get; } = ETipos.BICHO;
        
    public string Nombre { get; } = "Tijera X";
        
    public int Daño { get; } = 35;
        
    public int PP { get; } = 10;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = false;


    public TijeraX()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}