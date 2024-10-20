using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Planta;

public class HojaMagica: IMovimiento
{
    public ETipos Tipo { get; } = ETipos.PLANTA;
        
    public string Nombre { get; } = "Hoja Magica";
        
    public int Daño { get; } = 75;
        
    public int PP { get; } = 10;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = true;


    public HojaMagica()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}