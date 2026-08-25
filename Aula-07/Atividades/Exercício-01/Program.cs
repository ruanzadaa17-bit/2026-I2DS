internal class Program
{
    public class Fruta
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
        
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM FRUTAS ===");

        // 1 - Iniciar um nova lista
        List<Fruta> listaFrutas = new List<Fruta>();

        Fruta fruta1 = new Fruta{ 
            Id = 1, Nome = "Banana"};
        Fruta fruta2 = new Fruta{ 
            Id = 2, Nome = "Pera"};
        Fruta fruta3 = new Fruta{ 
            Id = 3, Nome = "Uva"};
        Fruta fruta4 = new Fruta{ 
            Id = 2, Nome = "Morango"};
        Fruta fruta5 = new Fruta{ 
            Id = 3, Nome = "Amora"};

            // 2 - Incluir elementos em uma lista
        listaFrutas.Add(fruta1);
        listaFrutas.Add(fruta2); 
        listaFrutas.Add(fruta3);
        listaFrutas.Add(fruta4); 
        listaFrutas.Add(fruta5);

        foreach (var item in listaFrutas)
        {
            Console.WriteLine($"{item.Nome} ");
        }
        
        Console.WriteLine();
        Console.WriteLine("=== LISTA ATUALIZADA ===");
        Console.WriteLine();

        Fruta fruta6 = new Fruta{ 
            Id = 3, Nome = "Jaca"};
        listaFrutas.Add(fruta6);

        foreach (var item in listaFrutas)
        {
            Console.WriteLine($"{item.Nome} ");
        }
    }
}