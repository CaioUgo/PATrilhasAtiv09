using System;

class Retangulo
{   
	double perimetro = 0;
	double area = 0;
	double baseRetangulo = 0;
	double altura = 0;
	
    public void Inseririnformacoes()
    {
        Console.WriteLine("Digite a base do retângulo: ");
        baseRetangulo = double.Parse(Console.ReadLine());
        
        Console.WriteLine("\n\rDigite a altura do retângulo: ");
        altura = double.Parse(Console.ReadLine());
        
        Console.WriteLine("\n\rInformações salvas com sucesso!\n\r");
    }
    
    public void CalcularPerimetro()
    {
    	perimetro = 2* (baseRetangulo + altura);
    	Console.WriteLine("O perímetro do retângulo é {0}\n\r", perimetro);
    	return;
    } 
    
    public void CalcularArea()
    {
    	area = baseRetangulo * altura;
    	Console.WriteLine("A área do retângulo é {0}\n\r", area);
    	return;
    }   
}

class Program
{   
    static void Main()
    {
        Retangulo retan = new Retangulo();
    
        while(true)
        {   
            Console.WriteLine("=====================");
            Console.WriteLine("1. Inserir informações do retângulo");
            Console.WriteLine("2. Verificar perímetro do retângulo");
            Console.WriteLine("3. Verificar área do retângulo");
            Console.WriteLine("4. Sair");
            Console.WriteLine("=====================");
            
            Console.WriteLine("\n\rQual operação deseja realizar?");
            string opcao = Console.ReadLine();
            
            Console.Clear();
            
            switch(opcao)
            {
                case "1":
                    retan.Inseririnformacoes();
                    break;
                    
                case "2":
                    retan.CalcularPerimetro();
                    break;
                
               	case "3":
                    retan.CalcularArea();
                    break;
                    
                case "4":
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
