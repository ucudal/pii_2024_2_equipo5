using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Normal;

public class AtaqueRapido: IMovimiento
{
    public ETipos Tipo { get; } = ETipos.NORMAL;
        
    public string Nombre { get; } = "Ataque Rapido";
        
    public int Daño { get; } = 20;
        
    public int PP { get; } = 20;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = false;


    public AtaqueRapido()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }

}