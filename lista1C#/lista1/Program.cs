using System;

namespace lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma das atividades deste sistema:\n1)Conversor\n2)Maior&Menor\n3)Mensagem idade\n4)Fibonacci\n5)Ordenação");
            string aux = Console.ReadLine();

            switch(Double.Parse(aux)){
                case 1:
                    Console.WriteLine("$$$$$$$$$$$$$$$$ Bem-vindo ao conversor $$$$$$$$$$$$$$$$");
                    Console.WriteLine("Escolha uma das conversões disponíveis:\n1 => Dólar\n2 => Euro\n3 => Pesos Argentinos");
                    string moeda =  Console.ReadLine();
                    Console.WriteLine("Informe um valor em Reais R$");
                    string valor = Console.ReadLine();
                    switch(Double.Parse(moeda)){
                        case 1:
                            double valueD = Double.Parse(valor) / 5.17;
                            Console.WriteLine("Valor Convertido: U$" + valueD);
                            break;
                        case 2:
                            double valueE = Double.Parse(valor) / 6.14;
                            Console.WriteLine("Valor Convertido: EU$" + valueE);
                            break;
                        case 3:
                            double valueP = Double.Parse(valor) / 0.05;
                            Console.WriteLine("Valor Convertido: AR$" + valueP);
                            break;    
                    }
                    break;
                case 2:
                    Console.WriteLine("$$$$$$$$$$$$$$$$ Bem-vindo ao comparador de Maior&Menor $$$$$$$$$$$$$$$$");
                    Console.WriteLine("Informe o primeiro valor:");
                    string val1 = Console.ReadLine();
                    Console.WriteLine("Informe o segundo valor:");
                    string val2 = Console.ReadLine();
                    if(Double.Parse(val1) > Double.Parse(val2)){
                        Console.WriteLine("O primeiro valor: " + val1 + " é maior ");
                    }else{
                        Console.WriteLine("O segundo valor: " + val2 + " é maior ");
                    }
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;                
            }
        }
    }
}
