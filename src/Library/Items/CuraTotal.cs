namespace Library.Interfaces;

public class CuraTotal : IItems
{
    public string Nombre { get; set; }

    public void Usar(IPokemon pokemon)
    {
        pokemon.Estado = EEstado.Normal;
    }
}