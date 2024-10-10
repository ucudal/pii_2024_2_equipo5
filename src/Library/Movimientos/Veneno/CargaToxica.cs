using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Veneno;

public class CargaToxica: IMovimiento
{
    public ETipos ETipos { get; } = ETipos.VENENO;
        
    public string Nombre { get; } = "Carga Toxica";
        
    public int Daño { get; } = 40;
        
    public int PP { get; } = 5;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = true;


    public CargaToxica()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}