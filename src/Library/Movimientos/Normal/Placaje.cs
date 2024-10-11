using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Normal;

public class Placaje: IMovimiento
{
    public ETipos Tipos { get; } = ETipos.NORMAL;
        
    public string Nombre { get; } = "Placaje";
        
    public int Daño { get; } = 25;
        
    public int PP { get; } = 15;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = false;


    public Placaje()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}