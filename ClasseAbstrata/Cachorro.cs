namespace ClasseAbstrata;

public class Cachorro : Animal
{
    // Implementando o método abstrato da classe Animal
    public override string GetInformacoes()
    {
        return "Cachorro é um bom amigo";
    }
}