internal class Program
{
    private static void Main(string[] args)
    {
         // Primeiro Aluno
        Aluno aluno1 = new Aluno();
        aluno1.RM = 8876;
        aluno1.Nome = "Robson";
        aluno1.Email = "robsonchavao@gmail.com";
        aluno1.Nascimento = new DateOnly (2000,07,09);

        // Segundo Aluno
        Aluno aluno2 = new Aluno();
        aluno2.RM = 1234;
        aluno2.Nome = "Cleiton";
        aluno2.Email = "cleitondiquebra@gmail.com";
        aluno2.Nascimento = new DateOnly(2000,10,09);

        // Terceiro Aluno
        Aluno aluno3 = new Aluno();
        aluno3.RM = 4543;
        aluno3.Nome = "Carlos";
        aluno3.Email = "carlosdugrau@gmail.com";
        aluno3.Nascimento = new DateOnly(2000,03,01);

        // Exibindo os Alunos na tela
        Console.WriteLine("                    ======= Alunos =======");
        Console.WriteLine($"\nAluno 01: {aluno1.Nome}  |  RM: {aluno1.RM}  |  Email: {aluno1.Email}  |  Data Nascimento: {aluno1.Nascimento}");
        Console.WriteLine($"\nAluno 02: {aluno2.Nome}  |  RM: {aluno2.RM} |  Email: {aluno2.Email}  |  Data Nascimento: {aluno2.Nascimento}");
        Console.WriteLine($"\nAluno 03: {aluno3.Nome}  |  RM: {aluno3.RM} |  Email: {aluno3.Email}  |  Data Nascimento: {aluno3.Nascimento}");
    }
    public class Aluno
    {
        public int RM {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public DateOnly Nascimento {get; set;}
    }
}