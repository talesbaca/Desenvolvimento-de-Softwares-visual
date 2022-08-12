using System;

namespace Aula1108
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma altura: ");
            string altura = Console.ReadLine();
            Console.WriteLine("Informe uma largura: ");
            string largura = Console.ReadLine();
            Console.WriteLine("Area do retângulo: "  + AreaCompute(Double.Parse(altura), Double.Parse(largura)));
        }

        static double AreaCompute(double altura, double largura)
        {
            double area = altura * largura;
            return area;
        } 
    }
}
