// Recebe chave e valor, não permite duplicidade de chave

var dicionario = new Dictionary<int, string>()
{
    {5, "A"},
    {6,"BBB"}
};
dicionario.Add(100, "Teste");
dicionario[40] = "Curso";

//Console.WriteLine(dicionario[100]);

foreach (var item in dicionario)
{
    Console.WriteLine(item.Value);
}
