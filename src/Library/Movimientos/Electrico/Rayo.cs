using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Electrico;

public class Rayo: IMovimiento
{
    public ETipos Tipos { get; } = ETipos.ELECTRICO;
        
    public string Nombre { get; } = "Rayo";
        
    public int Daño { get; } = 45;
        
    public int PP { get; } = 5;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = true;


    public Rayo()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}