internal class Program
{
    public class Aluno
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
        public string? Idade {get; set;}
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("=== LISTA DE ALUNOS ===");

        // 1 - Iniciar um nova lista
        List<Aluno> listaAlunos = new List<Aluno>();

        Aluno aluno1 = new Aluno{ 
            Id = 1, Nome = "Robson",Idade = "15"};
        Aluno aluno2 = new Aluno{ 
            Id = 2, Nome = "Jobson",Idade = "16"};
        Aluno aluno3 = new Aluno{ 
            Id = 3, Nome = "Kobson",Idade = "17"};
            Aluno aluno4 = new Aluno{ 
            Id = 2, Nome = "Tompsom",Idade = "16"};
        Aluno aluno5 = new Aluno{ 
            Id = 3, Nome = "Irineu",Idade = "17"};

        // 2 - Incluir elementos em uma lista
        listaAlunos.Add(aluno1);
        listaAlunos.Add(aluno2); 
        listaAlunos.Add(aluno3);
        listaAlunos.Add(aluno4); 
        listaAlunos.Add(aluno5);

        foreach (var item in listaAlunos)
        {
            Console.WriteLine($"{item.Nome} - {item.Idade}");
        }

        Console.WriteLine("=== ALTERANDO A IDADE DE UM ALUNO ===");

        // 4 - Alterar um elemento da lista
        listaAlunos[1].Idade = "17";

        Console.WriteLine();
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");
        }
    
            Console.WriteLine("=== REMOVENDO UM ALUNO PELO NOME===");
            Console.WriteLine();
            Console.WriteLine("Removendo aluno 4 - Tompsom.....");
            listaAlunos.Remove(aluno4);
        Console.WriteLine();
        Console.WriteLine("=== ATUALIZAÇÃO DA LISTA ===");
        foreach (var aluno in listaAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");
        }
    }
}