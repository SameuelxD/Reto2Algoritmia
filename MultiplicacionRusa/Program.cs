internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el valor del multiplicador");
        var multiplicador=int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el valor del multiplicando");
        var multiplicando=int.Parse(Console.ReadLine());
        var resultado=0;
        while(multiplicador>=1){
            if(!(multiplicador%2==0)){
                resultado=resultado+multiplicando;
            }
            multiplicando=multiplicando*2;
            multiplicador=multiplicador/2;
        }
        Console.WriteLine($"Resultado: {resultado}");
    }
}