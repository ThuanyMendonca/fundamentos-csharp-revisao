namespace Datas;

public class AulaDateTime
{
    public void AulaDateTimeEx()
    {
        // Ano, Mês, Dia, Hora, Minuto, Segundos
        var date1 = new DateTime(2022, 12, 01, 19,22,34);
        var date2 = DateTime.Parse("2020/12/01 19:35:13");
        var date3 = DateTime.Now; // Hora atual
        var date4 = DateTime.Today; // Sem as horas
        
        Console.WriteLine(date1);
        Console.WriteLine(date2);
        Console.WriteLine(date3);
        Console.WriteLine(date4);
        
        // Formatando a data padrão brasileiro
        Console.WriteLine($"Data formatada -> {date1.ToString("dd-MM-yyyy HH:mm:ss")}");
        
        var dateOffset = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
        Console.WriteLine($"Local Date -> {dateOffset.LocalDateTime}");
        Console.WriteLine($"UTC 3 horas a mais -> {dateOffset.UtcDateTime}");
    }
}