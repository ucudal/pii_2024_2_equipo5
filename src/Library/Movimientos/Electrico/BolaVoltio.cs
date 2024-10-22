using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Electrico;

public class BolaVoltio: MovimientoSimple
{
    public BolaVoltio()
    {
        Tipo = ETipos.ELECTRICO;
        Nombre = "Bola Voltio";
        Daño = 40;
        PP = 10;
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}