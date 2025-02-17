using System;

class Livro
{   
    Random rand = new Random();
    int probabilidade = 0;
    
    public void Disponibilidade()
    {
        Console.WriteLine("Qual livro deseja checar sua disponibilidade: ");
        string livro = Console.ReadLine();
        
        probabilidade = rand.Next(1, 3); // Gera um número aleatório entre 1 e 2.
        
        if (probabilidade == 1)
        {
            Console.WriteLine("\n\rEsse livro está disponível para o empréstimo.\n\r");
        }
        else
        {
            Console.WriteLine("\n\rEsse livro não está disponível para o empréstimo.\n\r");
        }
    }
    
    public void Realizaremprestimo()
    {
        Console.WriteLine("Deseja realizar o empréstimo do livro? ");
        string opcao = Console.ReadLine().ToLower();
        
        if (opcao == "sim" && probabilidade == 1)
        {
        	Console.WriteLine("\n\rEmpréstimo realizado.\n\r");
        }
        else 
        {
        	Console.WriteLine("\n\rNão é possível realizar o empréstimo.\n\r");
        }
    }     
}

class Program
{   
    static void Main()
    {
        Livro liv = new Livro();
    
        while(true)
        {   
            Console.WriteLine("=====================");
            Console.WriteLine("1. Verificar disponibilidade do livro");
            Console.WriteLine("2. Realizar empréstimo");
            Console.WriteLine("3. Sair");
            Console.WriteLine("=====================");
            
            Console.WriteLine("\n\rQual operação deseja realizar?");
            string opcao = Console.ReadLine();
            
            Console.Clear();
            
            switch(opcao)
            {
                case "1":
                    liv.Disponibilidade();
                    break;
                    
                case "2":
                    liv.Realizaremprestimo();
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
