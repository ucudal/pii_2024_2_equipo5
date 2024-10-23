using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Dragon;

public class GarraDragon : MovimientoSimple
{ 
    public GarraDragon()
    {
        Tipo = ETipos.DRAGON;
        Nombre = "Garra Dragon";
        Daño = 45;
        PP = 10;
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}