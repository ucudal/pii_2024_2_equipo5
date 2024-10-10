using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Normal;

public class Salpicadura: IMovimiento
{
    public ETipos ETipos { get; } = ETipos.NORMAL;
        
    public string Nombre { get; } = "Salpicadura";
        
    public int Daño { get; } = 0;
        
    public int PP { get; } = 25;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = false;


    public Salpicadura()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}