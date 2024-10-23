using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Normal;

public class AtaqueRapido: MovimientoSimple
{
    public AtaqueRapido()
    {
        Tipo = ETipos.NORMAL;
        Nombre = "Ataque Rapido";
        Daño = 20;
        PP = 20;
        Precision = 100;
        CurrentPP = PP; // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}