namespace Library.Interfaces;

public class Revivir : IItems
{
    public string Nombre { get; set; }

    public void Usar(IPokemon pokemon)
    {
        if (pokemon.Debil)
        {
            pokemon.Debil = false;
            pokemon.SaludActual = pokemon.SaludTotal / 2;
        }
    }
}