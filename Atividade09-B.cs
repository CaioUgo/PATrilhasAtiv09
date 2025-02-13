using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		
		Console.WriteLine("Digite o tamanho da lista: ");
		int tamanho = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		List<string> palavras = new List<string>();

			for (int i = 0; i < tamanho; i++)
			{
			Console.WriteLine("Item {0}: ",i+1 );
			string entrada = Console.ReadLine();
			palavras.Add(entrada);
			}
			Console.Clear();

		
		Console.WriteLine("Os elementos da lista são: ");
			
		foreach (string palavra in palavras)
		{
			Console.Write(palavra + " ");
		}
		Console.WriteLine();
		Console.WriteLine("\n\rPressione qualquer tecla para encerrar.....");
		Console.ReadKey(true);
			
	}
	
    }
				
