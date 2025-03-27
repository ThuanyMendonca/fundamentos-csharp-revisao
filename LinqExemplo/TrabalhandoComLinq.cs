namespace LinqExemplo;

public class TrabalhandoComLinq
{
    public void LinqWhere()
    {
        string nomeCompleto = "Meu Nome Completo";
        var resultado = nomeCompleto.Where(p => p == 'p');

        foreach (var letra in resultado)
        {
            Console.WriteLine(letra);
        }
    }

    public void LinqComDelegate()
    {
        string nomeCompleto = "Meu nome completo é teste";
        
        Func<char, bool> filtro = c => c == 'e';
        
        var resultado = nomeCompleto.Where(filtro);
        
        foreach (var letra in resultado)
        {
            Console.WriteLine(letra);
        }
    }

    public void LinqComConsulta()
    {
        string nomeCompleto = "Meu nome completo é teste";
        var resultado = from c in nomeCompleto where c == 'e' select c;
        
        foreach (var letra in resultado)
        {
            Console.WriteLine(letra);
        }
    }

    public void LinqDeNumeros()
    {
        var numeros = new int[] { 10, 6, 5, 50, 15, 2 };
        var resultado = numeros.Where(n => n >= 10);
        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void OrdenacaoAsc()
    {
        var numeros = new int[] { 10, 6, 5, 50, 15, 2 };

        var resultado = numeros.OrderBy(n => n);
        
        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }
    
    public void OrdenacaoDesc()
    {
        var numeros = new int[] { 10, 6, 5, 50, 15, 2 };

        var resultado = numeros.OrderByDescending(n => n);
        
        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void OrdenacaoStrings()
    {
        var nomes = new string[] { "Rafael", "Eduardo", "Bruno" };
        
        var resultado = nomes.OrderBy(n => n);

        foreach (var nome in resultado)
        {
            Console.WriteLine(nome);
        }
    }

    public void LinqTake()
    {
        var numeros = new int[] { 10, 6, 5, 50, 15, 2 };
        
        // Take (quantidade de elementos que gostaria de pegar)
        var resultado = numeros.Where(n => n > 10).Take(3).OrderBy(n => n);

        foreach (var item in resultado)
        {
            Console.WriteLine(item);
        }
    }
    
    public void LinqCount()
    {
        var numeros = new int[] { 10, 6, 5, 50, 15, 2 };
        
        var resultado = numeros.Count(n => n > 10);
        Console.WriteLine(resultado);
    }

    // Quando não possui valor, o first retorna exception
    public void LinqFirst()
    {
        var numeros = new int[] { 10, 6, 5, 50, 15, 2 };
        var resultado = numeros.First();
        Console.WriteLine(resultado);
    }

    public void LinqFirstOrDefault()
    {
        var numeros = new int[] { };
        var resultado = numeros.FirstOrDefault();
        Console.WriteLine(resultado);
    }
    
    public void LinqFirstOrDefaultComValorPadrao()
    {
        var numeros = new int[] { 10, 6, 5, 50, 15, 2 };
        var resultado = numeros.FirstOrDefault(p => p > 100, -20);
        Console.WriteLine(resultado);
    }

    public void LinqValorDuplicado()
    {
        var numeros = new int[] { 10, 6, 5, 50, 15, 2, 5, 10, 5 };

        var unicos = numeros.Distinct();
        
        Console.WriteLine(string.Join(", ", unicos));

    }
}