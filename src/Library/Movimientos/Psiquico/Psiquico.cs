using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Psiquico;

public class Psiquico : MovimientoEspecial
{
    public Psiquico()
    {
        Tipo = ETipos.PSIQUICO;
        Nombre = "Psiquico";
        Daño = 45;
        //los PP los hereda ya que para los especiales siempre es 4
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}