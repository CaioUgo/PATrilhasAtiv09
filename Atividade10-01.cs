using System;
using System.Collections.Generic;

 class Calculadora 
 {
 	public int Somar(int a, int b){
 		return a + b;
 	}
	
 	public int Subtrair(int a, int b){
 		return a - b;
 	}
	
 	public double Dividir(double a, double b){
 		return a / b;
 	}
	
 	public double Multiplicar(double a, double b){
 		return a * b;
 	}
 	
 	public double RaizQuadrada(double a){
 		return Math.Sqrt(a);
 	}

 }

class Program
{
	static void Main()
	{	
		Console.WriteLine("1.Somar");
		Console.WriteLine("2.Subtrair");
		Console.WriteLine("3.Dividir");
		Console.WriteLine("4.Multiplicar");
		Console.WriteLine("5.Raiz Quadrada");
		Console.WriteLine("6.Sair");
		
		Console.WriteLine("\n\rQual operação deseja realizar?");
		string opcao = Console.ReadLine();
		
		Console.Clear();
		
		Calculadora calc = new Calculadora();
		
		switch(opcao)
		{
			case "1":
				
				Console.Write("Digite a primeira parcela: ");
				int parcela1 = int.Parse(Console.ReadLine());
				
				Console.Write("\n\rDigite a segunda parcela: ");
				int parcela2 = int.Parse(Console.ReadLine());
				
				int total = calc.Somar(parcela1, parcela2);
				
				Console.WriteLine("\n\rO resultado da soma é: {0}", total);
				break;
				
			case "2":
				Console.Write("Digite o minuendo: ");
				int minuendo = int.Parse(Console.ReadLine());
				
				Console.Write("\n\rDigite o subtraendo: ");
				int subtraendo = int.Parse(Console.ReadLine());
				
				int resto = calc.Subtrair(minuendo, subtraendo);
				
				Console.WriteLine("\n\rO resto da subtração é: {0}", resto);
				break;
				
			case "3":
				Console.Write("Digite o dividendo: ");
				double dividendo = double.Parse(Console.ReadLine());
				
				Console.Write("\n\rDigite o divisor: ");
				double divisor = double.Parse(Console.ReadLine());
				
				if (divisor == 0)
				{
					Console.WriteLine("Não é possível fazer divisão por zero!");
					return;
				}
				
				double restoDivisao = calc.Dividir(dividendo, divisor);
				
				Console.WriteLine("\n\rO resto da divisão é: {0}", restoDivisao);
				break;
				
			case "4":
				Console.Write("Digite o multiplicando: ");
				double multiplicando = double.Parse(Console.ReadLine());
				
				Console.Write("\n\rDigite o multiplicador: ");
				double multiplicador = double.Parse(Console.ReadLine());
				
				double produto = calc.Multiplicar(multiplicando, multiplicador);
				
				Console.WriteLine("\n\rO produto da multiplicação é: {0}", produto);
				break;
				
			case "5":
				Console.Write("Digite o radicando: ");
				double radicando = double.Parse(Console.ReadLine());
				
				double resultado = calc.RaizQuadrada(radicando);
				
				Console.WriteLine("\n\rO resultado da raiz quadrada é: {0}", resultado);
				break;
			
			case "6":
				return;
				
			default:
				return;
				
		}
		
		Console.WriteLine("\n\rPressione qualquer tecla para encerrar.....");
		Console.ReadKey(true);
			
	}
	
    }
				
