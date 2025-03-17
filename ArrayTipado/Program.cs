var arrayTipado = new int[3];
// ou new int[3]{1,2,3}
arrayTipado[0] = 1;
arrayTipado[1] = 2;
arrayTipado[2] = 10;

//arrayTipado[20] = 100; erro pois tem apenas 3 indices

Array.Resize(ref arrayTipado, 10); // após aumentar o tamanho, funciona
arrayTipado[9] = 100;
foreach (var item in arrayTipado)
{
    Console.WriteLine(item);
}

var arrayTipadoString = new string[2] {"Teste", "Teste 2"};

foreach (var item in arrayTipadoString)
{
    Console.WriteLine(item);
}