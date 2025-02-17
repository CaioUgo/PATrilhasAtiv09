using System;
using System.Collections.Generic;

class Contato
{
    public string Nome { get; set; }
    public string Telefone { get; set; }

    public Contato(string nome, string telefone)
    {
        Nome = nome;
        Telefone = telefone;
    }
}

class Agenda
{
    private List<Contato> contatos = new List<Contato>();

    public void AdicionarContato(string nome, string telefone)
    {
        Contato novoContato = new Contato(nome, telefone);
        contatos.Add(novoContato);
        Console.WriteLine("Contato adicionado com sucesso!");
    }

    public void RemoverContato(string nome)
    {
        Contato contatoRemover = contatos.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        
        if (contatoRemover != null)
        {
            contatos.Remove(contatoRemover);
            Console.WriteLine($"Contato {nome} removido com sucesso!");
        }
        else
        {
            Console.WriteLine($"Contato {nome} não encontrado.");
        }
    }

    public void BuscarContato(string nome)
    {
        Contato contato = contatos.Find(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        
        if (contato != null)
        {
            Console.WriteLine($"Contato encontrado: {contato.Nome} - {contato.Telefone}");
        }
        else
        {
            Console.WriteLine($"Contato {nome} não encontrado.");
        }
    }
}

class Program
{
    static void Main()
    {
        Agenda agenda = new Agenda();
        
        while (true)
        {
            Console.WriteLine("=====================");
            Console.WriteLine("1. Adicionar contato");
            Console.WriteLine("2. Remover contato");
            Console.WriteLine("3. Buscar contato");
            Console.WriteLine("4. Sair");
            Console.WriteLine("=====================");
            
            Console.WriteLine("\nEscolha uma opção:");
            string opcao = Console.ReadLine();

            Console.Clear();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Digite o nome do contato:");
                    string nomeAdicionar = Console.ReadLine();
                    Console.WriteLine("Digite o telefone do contato:");
                    string telefoneAdicionar = Console.ReadLine();
                    agenda.AdicionarContato(nomeAdicionar, telefoneAdicionar);
                    break;
                    
                case "2":
                    Console.WriteLine("Digite o nome do contato a ser removido:");
                    string nomeRemover = Console.ReadLine();
                    agenda.RemoverContato(nomeRemover);
                    break;
                
                case "3":
                    Console.WriteLine("Digite o nome do contato para buscar:");
                    string nomeBuscar = Console.ReadLine();
                    agenda.BuscarContato(nomeBuscar);
                    break;

                case "4":
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
