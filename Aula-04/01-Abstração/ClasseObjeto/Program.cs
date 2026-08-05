internal class Program
{
    private static void Main(string[] args)
    {
        /*
            Classe -> é a abstração de um objeto do mundo normal para o mundo computacional.
            Objeto -> É a instância de uma classe.
        */
        

        // Instanciar um objeto do Tipo Aluno
        Aluno aluno01 = new Aluno();
        

        Aluno aluno02 = new Aluno();
        

        // Atribuir valores
        aluno01.Nome = "José Da Silva";
        aluno01.RM = 2444;
        aluno01.DataNascimento = new DateOnly(2006,01,15);

        aluno02.Nome = "João dos Santos";
        aluno02.RM = 1234;
        aluno02.DataNascimento = new DateOnly(2006,12,07);

        // Executar os métodos
        aluno01.ApresentarSe();
        aluno02.ApresentarSe();
    }

    
    public class Aluno  // Declaração de uma classe
    {
        // Atributos -> Características
        public string Nome {get; set;}
        public int RM {get; set;}
        public DateOnly DataNascimento {get; set;}

        // Métodos -> Ações ou funcionalidades
        public void ApresentarSe()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, meu RM é {RM}, nasci na data {DataNascimento}");
        }
    }
}