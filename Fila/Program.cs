// FIFO - first in, first out

var queue = new Queue<string>();

// Empilhar o item na fila
queue.Enqueue("Teste");
queue.Enqueue("Teste 2");
queue.Enqueue("Teste 3");

//queue.Peek(); // retorna o primeiro valor que será removido da fila

queue.Dequeue();

foreach (var item in queue)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n\n**************************************");
Console.WriteLine("**************************************\n\n");

// LIFO - last in, first out (Stack - Pilha)

var stack = new Stack<string>();
stack.Push("Joao");
stack.Push("Maria");

// Maria
// Joao

Console.WriteLine("Saindo -> " + stack.Peek());
stack.Pop();
// Remove Maria

foreach(var item in stack)
{
    Console.WriteLine(item);    
}
