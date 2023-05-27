namespace AlcoolOuGasosa;
class Program
{
    static void Main(string[] args)
    {
        double gasosa;
        double Álcool;
        
        Console.Clear();
        
        Console.WriteLine("Álcool ou Gasosa?");

        Console.WriteLine();

        Console.Write("Digite o preço da Gasosa...: R$ ");
        gasosa = Convert.ToDouble(Console.ReadLine());


        Console.Write("Digite o preço do Álcool...: R$ ");
        Álcool = Convert.ToDouble(Console.ReadLine());

        double Diferença;

        Diferença = (gasosa / Álcool)*100; 

        Console.WriteLine($"O preço do Etanol corresponde a {Diferença:N1}% do preço da gasolina");

        if ( Diferença >= 0.73 )
        {
            Console.Write("É recomendado usar GASOSA");
        }

        if ( Diferença <= 0.73)
        {
            Console.Write("É recomendado usar Álcool");
        }
    }
}
