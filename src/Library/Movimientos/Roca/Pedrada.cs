using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Roca;

public class Pedrada: IMovimiento
{
    public ETipos Tipo { get; } = ETipos.ROCA;
        
    public string Nombre { get; } = "Pedrada";
        
    public int Daño { get; } = 45;
        
    public int PP { get; } = 25;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = false;


    public Pedrada()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}