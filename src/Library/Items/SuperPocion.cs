namespace Library.Interfaces;

public class SuperPocion : IItems
{
    public string Nombre { get; set; }

    public void Usar(IPokemon pokemon)
    {
        pokemon.SaludActual += 70;
        if (pokemon.SaludActual > pokemon.SaludTotal)
        {
            pokemon.SaludActual = pokemon.SaludTotal;
        }
    }
}