// See https://aka.ms/new-console-template for more information

using LinqExemplo;

var linq = new TrabalhandoComLinq();
//Utilizando WHERE
linq.LinqWhere();
linq.LinqComDelegate();
linq.LinqComConsulta();
linq.LinqDeNumeros();

Console.WriteLine("\n********************************\n");

// Utilizando ORDER BY
linq.OrdenacaoAsc();
linq.OrdenacaoDesc(); 
linq.OrdenacaoStrings();
linq.LinqTake();
linq.LinqCount();
linq.LinqFirst();
linq.LinqFirstOrDefault();
linq.LinqFirstOrDefaultComValorPadrao();
linq.LinqValorDuplicado();
