
using Records;

var curso1 = new Curso(){Id = 1, Descricao = "Curso 1"};
var curso2 = new Curso(){Id = 1, Descricao = "Curso 1"};

//Console.WriteLine(curso1 == curso2); -> não faz a comparação correta
Console.WriteLine(curso1.Equals(curso2)); // -> faz a comparação, porém precisa implementar métodos

var cursoComRecord1 = new CursoComRecord(1, "Curso");
// Copiando os valores de cursoComRecord1, passa apenas os valores que são diferentes 
var cursoComRecord2 = cursoComRecord1 with
{
    Descricao = "Teste Novo"
};
Console.WriteLine($"Copia -> {cursoComRecord2}");
//Console.WriteLine($"Comparação -> {cursoComRecord1 == cursoComRecord2}");

var cursoTeste1 = new CursoTeste(){Id = 1, Descricao = "Curso"};
//var cursoTeste2 = curso1; // isso não funciona, pois a classe cria uma referencia na memória e queremos copiar o valor
var cursoTeste2 = new CursoTeste();
cursoTeste2.Id = cursoTeste1.Id;
cursoTeste2.Descricao = "Nova descrição";

Console.WriteLine(cursoTeste1.Descricao);
Console.WriteLine(cursoTeste2.Descricao);

