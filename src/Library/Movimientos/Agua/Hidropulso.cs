using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Agua;

public class Hidropulso : MovimientoEspecial
{
    public Hidropulso()
    {
        Tipo = ETipos.AGUA;
        Nombre = "Hidropulso";
        Daño = 50;
        //los PP los hereda ya que para los especiales siempre es 4
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}