namespace Library.Interfaces;

public interface iMovimiento
{
    Enums.Tipos Tipos { get; }
        
    string Nombre { get; }
    int Daño { get; }
    int PP { get; }        // PP = PowerPoints.
    int CurrentPP { get; set; }  // ._.
    bool Especial { get; }
}