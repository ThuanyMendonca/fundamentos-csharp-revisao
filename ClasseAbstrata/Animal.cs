namespace ClasseAbstrata;

public abstract class Animal
{
    public string Nome { get; set; }
    
    // A sub classe precisa implementar esse método
    public abstract string GetInformacoes();

    public void ImprimirDados()
    {
        Console.WriteLine("Nome animal -> " + Nome);
        Console.WriteLine("Informações -> " + GetInformacoes());
    }
}