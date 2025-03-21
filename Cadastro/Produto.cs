namespace Cadastro;
public class Produto
{
    private int _id;
    public string? Descricao { get; set; }
    // Propriedade somente leitura
    // public readonly int Estoque;
    // ou
    public int Estoque { get; }

    /*
    public Produto()
    {
        Estoque = 10; // Pode ser settado no construtor
    }*/

    public Produto(int estoque)
    {
        Estoque = estoque;
    }
    public void ImprimirDescricao()
    {
        Console.WriteLine(GetId() + " - " + Descricao);
    }

    public void SetId(int id)
    {
        _id = id;
    }

    public int GetId()
    {
        return _id;
    }
}