using Library.Enums;
using Library.Interfaces;

namespace Library.Movimientos.Veneno;

public class LanzaMugre: IMovimiento
{
    public ETipos Tipos { get; } = ETipos.VENENO;
        
    public string Nombre { get; } = "Lanza Mugre";
        
    public int Daño { get; } = 45;
        
    public int PP { get; } = 5;
        
    public int CurrentPP { get; set; }
        
    public bool Especial { get; } = false;


    public LanzaMugre()
    {
        CurrentPP = PP;            // Esto es para inicializar la cantidad veces que podes usar un movimiento.
    }  
}