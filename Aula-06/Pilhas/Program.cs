internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM PILHAS   (FILO) ===");

        // 1 - Criar uma nova pilha vazia
        Stack<string> pilhasLivros = new Stack<string>();

        // 2 - Adicionar elementos em uma pilha
        pilhasLivros.Push("Dom quixote");
        pilhasLivros.Push("O Morro dos Ventos Uivantes");
        pilhasLivros.Push("O Cortiço");

        // 3 - Percorrer todos os elementos de uma pilha
        Console.WriteLine();
        foreach (var livro in pilhasLivros)
        {
            Console.WriteLine(livro);
        }

        // 4 - Remover um elemento da pilha
        string livroRemovido = pilhasLivros.Pop();
        Console.WriteLine();
        Console.WriteLine($"O livro retirado foi: {livroRemovido}");

        pilhasLivros.Push("Dom Casmurro");
        Console.WriteLine();
        Console.WriteLine();
        foreach (var livro in pilhasLivros)
        {
            Console.WriteLine(livro);
        }
    }
}