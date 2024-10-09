namespace DefaultNamespace;

public class iPokemon
{
    string Nombre { get; set; }
    int SaludTotal { get; set; } //(HPmax)
    int SaludActual { get; set; } //HPactual
    bool Debil { get; set; } //Si débil es true, está muerto
    int ValorAtaque { get; set; }
    int ValorDefensa { get; set; }
    int ValorAtaqueEspecial { get; set; }
    int ValorDefensaEspecial { get; set; }
    List<Tipos> Tipo { get; set; } 
    List<iMovimiento> Movimientos { get; set; }
    void RecibirDanio(int dañoRecibido);
    void UsarMovimiento(iMovimiento movimiento);
}