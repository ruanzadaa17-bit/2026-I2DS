internal class Program
{
    private static void Main(string[] args)
    {
     // Primeiro carro
        Carro carro1 = new Carro();
        carro1.Marca = "Fiat";
        carro1.Modelo = "Uno";
        carro1.Velocidade = 220;
    

        // Segundo carro
        Carro carro2 = new Carro();
        carro2.Marca = "Peugeot";
        carro2.Modelo = "207";
        carro2.Velocidade = 200;
    

        // Terceiro carro
        Carro carro3 = new Carro();
        carro3.Marca = "Volks";
        carro3.Modelo = "Jetta";
        carro3.Velocidade = 170;
    

        // Exibindo os carros
        Console.WriteLine("=== carros ===");

        Console.WriteLine("\ncarro 1");
        Console.WriteLine($"Marca: {carro1.Marca}");
        Console.WriteLine($"Modelo: {carro1.Modelo}");
        Console.WriteLine($"Velocidade atual: Km/h {carro1.Velocidade}");
        Console.WriteLine($"Velocidade acelerada: Km/h {carro1.Acelerar()}");

        Console.WriteLine("\ncarro 2");
        Console.WriteLine($"Marca: {carro2.Marca}");
        Console.WriteLine($"Modelo: {carro2.Modelo}");
        Console.WriteLine($"Velocidade atual: Km/h {carro2.Velocidade}");
        Console.WriteLine($"Velocidade acelerada: Km/h {carro2.Acelerar()}");
   
        Console.WriteLine("\ncarro 3");
        Console.WriteLine($"Marca: {carro3.Marca}");
        Console.WriteLine($"Modelo: {carro3.Modelo}");
        Console.WriteLine($"Velocidade atual: Km/h {carro3.Velocidade}");
        Console.WriteLine($"Velocidade acelerada: Km/h {carro3.Acelerar()}");
        Console.WriteLine($"Velocidade desacelerada: Km/h {carro3.Desacelerar()}");
    }
    }
    
    public class Carro
    {
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public int Velocidade {get; set;}
        public int Quantidade {get; set;}
        
        public int Acelerar()
        {
            return Velocidade + 10;
        }
        public int Desacelerar()
        {
            return Velocidade - 10;
        }
    }
    /* resolução do cris 
    
    internal class Program
{
    private static void Main(string[] args)
    {
       // Primeiro carro
        Carro carro1 = new Carro();
        carro1.Marca = "Toyota";
        carro1.Modelo = "Corolla";
        carro1.VelocidadeAtual = 0;

        // Segundo carro
        Carro carro2 = new Carro();
        carro2.Marca = "Volkswagen";
        carro2.Modelo = "Golf";
        carro2.VelocidadeAtual = 20;

        // Terceiro carro
        Carro carro3 = new Carro();
        carro3.Marca = "Honda";
        carro3.Modelo = "Civic";
        carro3.VelocidadeAtual = 30;

        // Exibindo informações iniciais
        Console.WriteLine("=== CARROS ===");

        Console.WriteLine("\nCarro 1");
        Console.WriteLine($"Marca: {carro1.Marca}");
        Console.WriteLine($"Modelo: {carro1.Modelo}");
        Console.WriteLine($"Velocidade: {carro1.VelocidadeAtual} km/h");

        Console.WriteLine("\nCarro 2");
        Console.WriteLine($"Marca: {carro2.Marca}");
        Console.WriteLine($"Modelo: {carro2.Modelo}");
        Console.WriteLine($"Velocidade: {carro2.VelocidadeAtual} km/h");

        Console.WriteLine("\nCarro 3");
        Console.WriteLine($"Marca: {carro3.Marca}");
        Console.WriteLine($"Modelo: {carro3.Modelo}");
        Console.WriteLine($"Velocidade: {carro3.VelocidadeAtual} km/h");

        // Acelerando o carro 1
        Console.WriteLine("\n=== ACELERANDO O CARRO 1 ===");

        carro1.Acelerar();
        Console.WriteLine($"Velocidade: {carro1.VelocidadeAtual} km/h");

        carro1.Acelerar();
        Console.WriteLine($"Velocidade: {carro1.VelocidadeAtual} km/h");

        // Desacelerando o carro 2
        Console.WriteLine("\n=== DESACELERANDO O CARRO 2 ===");

        carro2.Desacelerar();
        Console.WriteLine($"Velocidade: {carro2.VelocidadeAtual} km/h");

        carro2.Desacelerar();
        Console.WriteLine($"Velocidade: {carro2.VelocidadeAtual} km/h");

        carro2.Desacelerar();
        Console.WriteLine($"Velocidade: {carro2.VelocidadeAtual} km/h");
    }
    class Carro
{
    public string Marca;
    public string Modelo;
    public int VelocidadeAtual;

    public void Acelerar()
    {
        VelocidadeAtual += 10;
    }

    public void Desacelerar()
    {
        if (VelocidadeAtual >= 10)
        {
            VelocidadeAtual -= 10;
        }
        else
        {
            VelocidadeAtual = 0;
        }
    }
}

}*/

