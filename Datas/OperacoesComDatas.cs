namespace Datas;

public class OperacoesComDatas
{
    public void SubtraindoData()
    {
        var date1 = DateTime.Now;
        var date2 = DateTime.Parse("2022-01-01");
        
        //var diff = date1 - date2;
        var diff = date1.Subtract(date2);
        Console.WriteLine("\n ********************************* \n");
        Console.WriteLine($"Diferença em dias -> {Math.Round(diff.TotalDays)}");
        Console.WriteLine($"Diferença em horas -> {Math.Round(diff.TotalHours)}");
    }

    public void AdicionandoDiaMesAno()
    {
        var date1 = DateTime.Now;
        
        Console.WriteLine("\n ********************************* \n");
        Console.WriteLine($"Data atual -> {date1}");
        Console.WriteLine($"Adicionando dias -> {date1.AddDays(3).ToString("dd-MM-yyyy")}");
        Console.WriteLine($"Adicionando meses -> {date1.AddMonths(2)}");
        Console.WriteLine($"Adicionando anos -> {date1.AddYears(5)}");
        
    }
    
}