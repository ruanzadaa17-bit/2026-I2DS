internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== AGENDA TELEFÔNICA ===");

        // 1 - Criar um dicionário vazio
        Dictionary<string, string> dicionario = new Dictionary<string, string>();

        // 2 - Adicionar elementos no dicionario
        dicionario.Add("Robson","14 99988-7777");
        dicionario.Add("Claiton","14 99988-7766");
        dicionario.Add("Cleber","14 99988-7227");
        dicionario.Add("Marcio","14 99988-7117");

        // 3 - Percorrer todos os elemetos de um dicionario
        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        Console.WriteLine("");

        //  - Verificar se uma chave (key) existe dentro do dicionário
        
        Console.WriteLine($"Buscando contato na lista telefônica");

        bool chaveExiste = dicionario.ContainsKey("Marcio");
        Console.WriteLine();
        if (chaveExiste)
        {
            Console.WriteLine($"O contato foi encontrado: Marcio");
        }
        else
        {
            Console.WriteLine("O contato não foi encontrada na lista telefônica");
        }
        // 4 - Alterar um elemento do dicionario (telefone)
        Console.WriteLine("-----------------------------"); 
        Console.WriteLine("Um contato mudou de número (Robson)...");
        Console.WriteLine();
        Console.WriteLine("-----------------------------"); 
        Console.WriteLine();
        dicionario["Robson"] = "17 99887-5555";

        Console.WriteLine("Exibindo a agenda atualizada");
        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        // 6 - Excluir um contato -> Somente por Chave(Key)
        Console.WriteLine();
        Console.WriteLine("Excluindo um contato da lista");
        Console.WriteLine();
        dicionario.Remove("Claiton");
        Console.WriteLine();
        foreach (var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}