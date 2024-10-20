using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Planta;

public class LatigoCepa: IMovimiento
{
    public ETipos Tipo { get; } = ETipos.PLANTA;
        
    public string Nombre { get; } = "Latigo Cepa";
        
    public int Daño { get; } = 65;
        
    public int PP { get; } = 15;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = false;


    public LatigoCepa()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}