using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Planta;

public class LatigoCepa: MovimientoSimple
{
    public LatigoCepa()
    {
        Tipo = ETipos.PLANTA;
        Nombre = "Latigo Cepa";
        Daño = 30;
        PP = 15;
        Precision = 100;
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}