using System.Threading.Channels;

namespace CalcularDescuento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el tipo de cliente: ");
            string tipocliente = Console.ReadLine();

            Console.WriteLine("Introduce el importe a cobrar: ");
            decimal importe = decimal.Parse(Console.ReadLine());

            if (tipocliente.ToLower() == "empresarial")
            {
                Console.WriteLine("Descuento 10%");
                Console.WriteLine("Importe" + importe);
                Console.WriteLine($"Descuento: {(importe * 0.1m)}");
                Console.WriteLine($"Total: { importe - (importe * 0.1m)}");
            }
            else if(tipocliente.ToLower() == "preferencial")
            {
                Console.WriteLine("Descuento 10%");
                Console.WriteLine("Importe" + importe);
                Console.WriteLine($"Descuento: {(importe * 0.1m)}");
                Console.WriteLine($"Total: {importe - (importe * 0.1m)}");

            }
            else
            {
                Console.WriteLine("Descuento 0%");
                Console.WriteLine("Importe" + importe);
                Console.WriteLine("Descuento: 0.00");
                Console.WriteLine("Total: " + importe);
            }
        }
    }
}
