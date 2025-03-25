namespace ManipulandoArquivos;

public class Arquivos
{
    public void CriandoArquivos()
    {
        // append -> A cada execução ele vai adicionando as linhas no arquivo quando true
        var escrever = new StreamWriter("../../../cadastro.txt", true);
        Console.Write("Informe um nome: ");
        
        var nome = Console.ReadLine();
        
        escrever.WriteLine("ID -> " + Random.Shared.Next(1, 100));
        escrever.WriteLine("Nome - " + nome);
        escrever.WriteLine("---------------------------");
        
        escrever.Close();
    }

    public void LendoArquivos()
    {
        //var leitura = File.ReadAllText("../../../cadastro.txt");
        //Console.WriteLine(leitura);
        
        // ou ter mais controle de cada linha
        var ler = new StreamReader("../../../cadastro.txt");
        while (!ler.EndOfStream)
        {
            var linha = ler.ReadLine();
            Console.WriteLine(linha);
        }
        
        ler.Close();
    }

    public void ExcluindoArquivos()
    {
        if (File.Exists("../../../cadastro.txt"))
        {
            File.Delete("../../../cadastro.txt");
        }
    }
}