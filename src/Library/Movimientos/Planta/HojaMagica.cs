using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Planta;

public class HojaMagica: MovimientoEspecial
{
    public HojaMagica()
    {
        Tipo = ETipos.PLANTA;
        Nombre = "Hoja Mágica";
        Daño = 35;
        Precision = 100;
        //los PP los hereda ya que para los especiales siempre es 4
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}