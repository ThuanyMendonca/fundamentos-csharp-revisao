namespace Records;

/*
public record CursoComRecord
{
    public int Id { get; set; }
    public string Descricao { get; set; }
}
*/

public record CursoComRecord(int Id, string Descricao);