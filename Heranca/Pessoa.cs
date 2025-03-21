namespace Heranca;

public class Pessoa
{
    public int Id { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }
    public string Cep { get; set; }

    public void ImprimirDados()
    {
        Console.WriteLine($"\n Código: {Id}\n Endereco: {Endereco} \n Cidade: {Cidade} \n Cep: {Cep}");
    }
}