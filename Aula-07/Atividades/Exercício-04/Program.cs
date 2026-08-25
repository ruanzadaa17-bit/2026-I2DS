internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DE ATENDIMENTO ===");

        // 1 - Criar uma nova fila vazia
        Queue<string> filaBanco = new Queue<string>();

        // 2 - Adicionar elementos na fila
        filaBanco.Enqueue("João");       // 0
        filaBanco.Enqueue("Maria");      // 1
        filaBanco.Enqueue("Carlos");     // 2
        filaBanco.Enqueue("Ana");        // 3
        filaBanco.Enqueue("Pedro");      // 4

        // 3 - Percorrer elementos de uma fila
        Console.WriteLine();
        foreach(var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // 4 - Atender primeiro cliente
        string pessoaRetirada = filaBanco.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O nome chamado foi: {pessoaRetirada}");
        Console.WriteLine();
        Console.WriteLine($"{pessoaRetirada} foi atendido.");

        Console.WriteLine();
        Console.WriteLine("FIla restante:");
        foreach(var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        Console.WriteLine("Outra pessoa entrou na fila.");

        filaBanco.Enqueue("Samanta");
        Console.WriteLine();
        foreach(var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        
    }
}