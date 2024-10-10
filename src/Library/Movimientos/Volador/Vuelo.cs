using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Volador;

public class Vuelo: iMovimiento
{
    public Tipos Tipos { get; } = Tipos.VOLADOR;
        
    public string Nombre { get; } = "Vuelo";
        
    public int Daño { get; } = 45;
        
    public int PP { get; } = 5;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = false;


    public Vuelo()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}