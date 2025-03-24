using Records;

private void static AulaRecord()
{
    var curso1 = new Curso(){Id = 1, Descricao = "Curso 1"};
    var curso2 = new Curso(){Id = 2, Descricao = "Curso 2"};
    Console.WriteLine(curso1 == curso2);
}
