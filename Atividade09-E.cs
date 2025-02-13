using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		
		Console.WriteLine("Digite o tamanho da lista: ");
		int tamanho = int.Parse(Console.ReadLine());
		Console.WriteLine();
		
		List<double> numeros = new List<double>();

			for (int i = 0; i < tamanho; i++)
			{
			Console.WriteLine("Item {0}: ",i+1 );
			double entrada = double.Parse(Console.ReadLine());
			numeros.Add(entrada);
			}
			Console.Clear();
		
			int soma = 0;
			
		foreach (int numero in numeros)
		{
			soma += numero;
		}
		
		double media = (double)soma / numeros.Count;
		
		Console.WriteLine("\n\rA média dos números da lista é {0:F2}",media);
		Console.WriteLine("\n\rPressione qualquer tecla para encerrar.....");
		Console.ReadKey(true);
			
	}
	
    }
				
