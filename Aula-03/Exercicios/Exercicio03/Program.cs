using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        string nome;
        int nota1;
        int nota2;
        int nota3;
        
        Console.Write("Informe o seu nome: ");
            nome = Console.ReadLine();       

        Console.Write("Digite sua primeira nota: ");
        nota1 = int.Parse(Console.ReadLine());

        Console.Write("Digite sua segunda nota: "); 
        nota2 = int.Parse(Console.ReadLine());

        Console.Write("Digite sua terceira nota: ");
        nota3 = int.Parse(Console.ReadLine());

        double media = (nota1 + nota2 + nota3) / 3;
        if (media >= 7)
        {
            Console.WriteLine("Aluno: " + nome );
            Console.WriteLine("Situação: Aprovado com a média de " + media );
        }
        else if (media >= 5)
        {
            Console.WriteLine("Aluno: " + nome);
            Console.WriteLine("Situação: Recuperação com a média de " + media);
        }else{
            Console.WriteLine("Aluno: " + nome);
            Console.WriteLine("Situação: Reprovado com a média de " + media);
        }
    }
}