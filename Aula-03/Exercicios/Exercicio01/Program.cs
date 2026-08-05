internal class Program
{
    private static void Main(string[] args)
    
    {
        int celsius;
        
        Console.Write("Digite a temperatura desejada em graus celcius: ");
        celsius = int.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5 + 32);
        Console.WriteLine("A temperatura em fahrenheit é: " + fahrenheit);
    }
} 