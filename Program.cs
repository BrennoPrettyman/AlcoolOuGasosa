namespace AlcoolOuGasosa;
class Program
{
    static void Main(string[] args)
    {
        decimal gasosa;
        decimal Álcool;
        
        Console.Clear();
        
        Console.WriteLine("Álcool ou Gasosa?");

        Console.WriteLine();

        Console.Write("Digite o preço da gasosa...: R$ ");
        gasosa = Convert.ToDecimal(Console.ReadLine());


        Console.Write("Digite o preço do Álcool...: R$ ");
        Álcool = Convert.ToDecimal(Console.ReadLine());
    }
}
