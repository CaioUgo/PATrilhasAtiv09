using System;

class Triangulo
{   
	double lado1 = 0;
	double lado2 = 0;
	double lado3  = 0;
	
    public void Inseririnformacoes()
    {
        Console.WriteLine("Digite o primerio lado do triângulo: ");
        lado1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o segundo lado do triângulo: ");
        lado2 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o terceiro lado do triângulo: ");
        lado3 = double.Parse(Console.ReadLine());
        
        Console.Clear();
        
        Console.WriteLine("\n\rInformações salvas com sucesso!\n\r");
    }
    
  public void VerificarTipo()
    {
        if (lado1 == lado2 && lado1 == lado3)
        {
            Console.WriteLine("O triângulo é equilátero.\n\r");
        }
        else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
        {
            Console.WriteLine("O triângulo é isósceles.\n\r");
        }
        else
        {
            Console.WriteLine("O triângulo é escaleno.\n\r");
        }
    }
}

class Program
{   
    static void Main()
    {
        Triangulo triang = new Triangulo();
    
        while(true)
        {   
            Console.WriteLine("=====================");
            Console.WriteLine("1. Inserir informações do triângulo");
            Console.WriteLine("2. Verificar tipo do triângulo");
            Console.WriteLine("3. Sair");
            Console.WriteLine("=====================");
            
            Console.WriteLine("\n\rQual operação deseja realizar?");
            string opcao = Console.ReadLine();
            
            Console.Clear();
            
            switch(opcao)
            {
                case "1":
                    triang.Inseririnformacoes();
                    break;
                    
                case "2":
                   triang.VerificarTipo();
                    break;
                
                case "3":
                    Console.WriteLine("Saindo...");
                    return;
            
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
            Console.ReadKey(true);
        }
    }
}
