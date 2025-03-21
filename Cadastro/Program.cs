// See https://aka.ms/new-console-template for more information

using Cadastro;

var produto = new Produto(20);
produto.Descricao = "Teste descricao";
produto.SetId(1);
produto.ImprimirDescricao();
Console.WriteLine("Estoque -> " + produto.Estoque);

var soma = Calculos.SomarNumeros(2,3);
Console.WriteLine(soma);