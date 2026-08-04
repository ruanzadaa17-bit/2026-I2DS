using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
    /* Se (condicao) for verdadeiro executar essa função
    Senão
    execute essa função

    if(condicao)
    {
        codigo se verdadeiro
        }else{
        codigo se falso
    }
     */

     // Verificar se a idade é maior que 18 anos
    int idade = 15;
    if(idade >= 18)
        {
            Console.WriteLine("Maior de idade");
        }
        else
        {
            Console.WriteLine("Menor de idade");

        }

        /*****************************************************************************/
        Console.WriteLine("Digite a Nota: ");
        int nota = int.Parse(Console.ReadLine());

        if (nota >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
            
        }
        /*******************************************************/

        bool bloquado = false;

        if (!bloquado)
        {
            Console.WriteLine("Acesso Permitido!");
        }

/*********************************************************************/
        Console.WriteLine("1 - Cadastrar");
        Console.WriteLine("2 - Consultar");
        Console.WriteLine("3 - Excluir");
        Console.WriteLine("4 - Sair");

        Console.WriteLine("Escolha uma opção: ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
            Console.WriteLine("Cadastro slecionado");
            break;
            case 2:
            Console.WriteLine("Consulta selecionada");
            break;
            case 3:
            Console.WriteLine("Exclusão selecionada");
            break;
            case 4:
            Console.WriteLine("Encerrando o Sistema.");
            break;
            default:
            Console.WriteLine("Opção inválida.");
            break;


        }
    }
}