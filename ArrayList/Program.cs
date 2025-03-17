// Array list

using System.Collections;

var arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add("Teste");
arrayList.Add(true);

arrayList.Remove("Teste"); //  remover um valor específico (se existir)

arrayList.RemoveAt(0); // remove o item da posição 0 do array, no caso o núemro 1

arrayList.Clear(); // Limpa o array
//ou
// arrayList = new ArrayList();

// Caso queira o indice do array, é necessário inicializar a variável contator e incrementar
int i = 0;
foreach (var item in arrayList)
{
    Console.WriteLine($"Indice -> {i} - {item}");
    i++;
}

// Array tipado