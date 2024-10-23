using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Volador;

public class Picotazo: MovimientoSimple
{ 
    public Picotazo()
    {
        Tipo = ETipos.VOLADOR;
        Nombre = "Picotazo";
        Daño = 20;
        PP = 25;
        Precision = 100;
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}