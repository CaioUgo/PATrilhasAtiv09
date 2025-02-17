using System;
using System.Collections.Generic;

class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    
    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }
}

class CarrinhoDeCompras
{
    private List<Produto> itens = new List<Produto>();
    
    public void AdicionarProduto(Produto produto)
    {
        itens.Add(produto);
    }
    
    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var item in itens)
        {
            total += item.Preco;
        }
        return total;
    }
    
    public void ExibirItens()
    {
        foreach (var item in itens)
        {
            Console.WriteLine("{0}: R$ {1:F2}", item.Nome, item.Preco);
        }
    }
}

class Program
{
    static void Main()
    {
        CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
        carrinho.AdicionarProduto(new Produto("Notebook", 3500.99m));
        carrinho.AdicionarProduto(new Produto("Mouse", 150.75m));
        
        Console.WriteLine("Itens no carrinho:");
        carrinho.ExibirItens();
        
        Console.WriteLine("Total: R$ {0}:F2 ",carrinho.CalcularTotal());
    }
}
