using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Psiquico;

public class Psicoonda: IMovimiento
{
    public ETipos ETipos { get; } = ETipos.PSIQUICO;
        
    public string Nombre { get; } = "Psicoonda";
        
    public int Daño { get; } = 32;
        
    public int PP { get; } = 10;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = true;


    public Psicoonda()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}