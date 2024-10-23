namespace Library.Interfaces;

public interface IItems
{
    string Nombre { get; set; }
    void Usar(IPokemon pokemon);
}