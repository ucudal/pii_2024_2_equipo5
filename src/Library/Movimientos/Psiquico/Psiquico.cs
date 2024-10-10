using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Psiquico;

public class Psiquico : iMovimiento
{
    public Tipos Tipos { get; } = Tipos.PSIQUICO;
        
    public string Nombre { get; } = "Psiquico";
        
    public int Daño { get; } = 45;
        
    public int PP { get; } = 5;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = true;


    public Psiquico()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }
}