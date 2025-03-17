// Mais perfomatica que o array list

var lista = new List<string>(10)
{
    "ABC",
    "DEF"
};
lista.Add("WAS");
lista.Add("OPT");

lista.RemoveAt(1);
foreach (var item in lista)
{
    Console.WriteLine(item);
}