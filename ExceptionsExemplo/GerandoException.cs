namespace ExceptionsExemplo;

public class GerandoException
{
    public void CriandoException()
    {
        while (true)
        {
            Console.Write("Informe um numero: ");
            var numero = Console.ReadLine();
            var resultado = 500 / int.Parse(numero);
            Console.WriteLine(resultado);
        }
    }
    
    public void TratandoException()
    {
        try
        {
            Console.Write("Informe um numero: ");
            var numero = Console.ReadLine();
            var resultado = 500 / int.Parse(numero);
            Console.WriteLine(resultado);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"Erro ->>>> {e.Message}");
            Console.WriteLine($"Stack Trace ->>>> {e.StackTrace}");
            
            throw;
        }
    }
}