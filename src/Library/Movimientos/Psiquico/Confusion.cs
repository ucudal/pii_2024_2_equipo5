using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Psiquico;

public class Confusion: IMovimiento
{
    public ETipos Tipo { get; } = ETipos.PSIQUICO;
        
    public string Nombre { get; } = "Confusion";
        
    public int Daño { get; } = 30;
        
    public int PP { get; } = 4;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = true;


    public Confusion()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}