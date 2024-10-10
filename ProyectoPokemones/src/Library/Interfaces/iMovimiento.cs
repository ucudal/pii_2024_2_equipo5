namespace DefaultNamespace;

public class iMovimiento
{
    Enumeraciones.Tipos Tipos { get; }
        
    string Nombre { get; }
    int Daño { get; }
    int PP { get; }        // PP = PowerPoints.
    int CurrentPP { get; set; }  // ._.
    bool Especial { get; }

}