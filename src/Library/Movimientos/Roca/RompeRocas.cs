using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Roca;

public class RompeRocas: IMovimiento
{
    public ETipos Tipo { get; } = ETipos.ROCA;
        
    public string Nombre { get; } = "Rompe Rocas";
        
    public int Daño { get; } = 80;
        
    public int PP { get; } = 5;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = false;


    public RompeRocas()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}