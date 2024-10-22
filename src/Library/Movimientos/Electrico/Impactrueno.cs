using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Electrico;

public class Impactrueno: MovimientoEspecial
{
    public Impactrueno()
    {
        Tipo = ETipos.ELECTRICO;
        Nombre = "Impactrueno";
        Daño = 25;
        //los PP los hereda ya que para los especiales siempre es 4
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}