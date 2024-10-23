using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Bicho;

public class TijeraX: MovimientoSimple
{
    public TijeraX()
    {
        Tipo = ETipos.BICHO;
        Nombre = "TijeraX";
        Daño = 35;
        Precision = 100;
        PP = 10;
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}