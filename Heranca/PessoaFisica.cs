namespace Heranca;

public class PessoaFisica : Pessoa
{
    public string Cpf { get; set; }

    public void ImprimirCpf()
    {
        Console.WriteLine($"\n CPF: {this.Cpf}");
    }
}