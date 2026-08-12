internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM FILAS (FIFO) ===");

        // 1 - Criar uma nova fila vazia
        Queue<string> filaBanco = new Queue<string>();

        // 2 - Adicionar elementos na fila
        filaBanco.Enqueue("Zuleika");       // 0
        filaBanco.Enqueue("Asdrúbal");      // 1
        filaBanco.Enqueue("Pafúncio");      // 2
        filaBanco.Enqueue("Epaminondas");   // 3

        // 3 - Percorrer elementos de uma fila
        Console.WriteLine();
        foreach(var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // 4 - Retirar um elemento da lista
        string pessoaRetirada = filaBanco.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O nome chamado foi: {pessoaRetirada}");

        filaBanco.Enqueue("Lucrécia");
        Console.WriteLine();
        foreach(var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // 5 - Verificar se existe um determinado elemento na lista
        string procurar = "Pafúncio";
        bool achou = filaBanco.Contains(procurar);

        if (achou)
        {
            Console.WriteLine($"{procurar} está na fila!");
        }
        else
        {
            Console.WriteLine($"{procurar} não está na fila");
        }
    }
}