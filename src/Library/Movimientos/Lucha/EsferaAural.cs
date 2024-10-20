using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Lucha;

public class EsferaAural: IMovimiento
{
    public ETipos Tipo { get; } = ETipos.LUCHA;
        
    public string Nombre { get; } = "Esfera Aural";
        
    public int Daño { get; } = 80;
        
    public int PP { get; } = 10;
         
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = true;


    public EsferaAural()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}