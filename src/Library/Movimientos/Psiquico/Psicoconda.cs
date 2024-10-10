using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Psiquico;

public class Psicoconda: iMovimiento
{
    public Tipos Tipos { get; } = Tipos.PSIQUICO;
        
    public string Nombre { get; } = "Psicoonda";
        
    public int Daño { get; } = 32;
        
    public int PP { get; } = 10;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = true;


    public Psicoconda()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}