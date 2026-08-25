internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== HISTÓRICO DE NAVEGAÇÃO ===");

        // 1 - Criar uma nova pilha vazia
        Stack<string> histNaveg = new Stack<string>();

        // 2 - Adicionar elementos em uma pilha
        histNaveg.Push("google.com");
        histNaveg.Push("youtube.com");
        histNaveg.Push("github.com");
        histNaveg.Push("microsoft.com");

        // 3 - Percorrer todos os elementos de uma pilha
        Console.WriteLine();
        foreach (var acessos in histNaveg)
        {
            Console.WriteLine(acessos);
        }

    }
}