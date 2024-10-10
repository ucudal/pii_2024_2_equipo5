using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Agua;

public class ShurikenDeAgua: iMovimiento
{
    public Tipos Tipos { get; } = Tipos.AGUA;
        
    public string Nombre { get; } = "Shuriken de Agua";
        
    public int Daño { get; } = 20;
        
    public int PP { get; } = 25;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = false;


    public ShurikenDeAgua()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}