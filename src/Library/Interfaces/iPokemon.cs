namespace Library.Interfaces;

public interface iPokemon
{
    string Nombre { get; set; }
    int SaludTotal { get; set; }
    int SaludActual { get; set; }
    bool Debil { get; set; }
    int ValorAtaque { get; set; }
    int ValorDefensa { get; set; }
    int ValorAtaqueEspecial { get; set; }
    int ValorDefensaEspecial { get; set; }
    List<Tipos> Tipo { get; set; } 
    List<iMovimiento> Movimientos { get; set; }
    void RecibirDanio(int dañoRecibido);
    void UsarMovimiento(iMovimiento movimiento);
}