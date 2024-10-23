using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Agua;

public class ShurikenDeAgua: MovimientoSimple
{
    public ShurikenDeAgua()
    {
        Tipo = ETipos.AGUA;
        Nombre = "Shuriken de Agua";
        Daño = 20;
        PP = 25;
        Precision = 100;
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}