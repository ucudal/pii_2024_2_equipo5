using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Electrico;

public class BolaVoltio: IMovimiento
{
    public ETipos Tipo { get; } = ETipos.ELECTRICO;
        
    public string Nombre { get; } = "Bola Voltio";
        
    public int Daño { get; } = 40;
        
    public int PP { get; } = 10;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = false;


    public BolaVoltio()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}