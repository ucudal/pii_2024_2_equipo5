using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Lucha;

public class PuñoCertero: IMovimiento
{
    public ETipos Tipo { get; } = ETipos.LUCHA;
        
    public string Nombre { get; } = "Puño certero";
        
    public int Daño { get; } = 120;
        
    public int PP { get; } = 3;
         
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = false;


    public PuñoCertero()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}