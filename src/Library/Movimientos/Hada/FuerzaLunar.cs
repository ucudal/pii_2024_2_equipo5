using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Hada;

public class FuerzaLunar: iMovimiento
{
    public Tipos Tipos { get; } = Tipos.HADA;
        
    public string Nombre { get; } = "Fuerza Lunar";
        
    public int Daño { get; } = 50;
        
    public int PP { get; } = 5;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = true;


    public FuerzaLunar()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}