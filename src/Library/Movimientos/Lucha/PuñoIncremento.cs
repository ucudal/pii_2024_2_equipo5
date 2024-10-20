using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Lucha;

public class PuñoIncremento: IMovimiento
{
    public ETipos Tipo { get; } = ETipos.LUCHA;
        
    public string Nombre { get; } = "Puño incremento";
        
    public int Daño { get; } = 60;
        
    public int PP { get; } = 15;
         
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = false;


    public PuñoIncremento()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}