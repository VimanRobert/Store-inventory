/*
 * Created by SharpDevelop.
 * User: rober
 * Date: 7/25/2022
 * Time: 5:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

class Inventar{
	double rez, total;
	public void calculeaza(){
		Console.WriteLine("****Cate produse sunt in lista ?");
		int nrProd = Convert.ToInt32(Console.ReadLine());
		
		for(int i=1;i<=nrProd;i++){		
		Console.WriteLine("["+i+"]"+"Cantitate: ");
		int x = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("["+i+"]"+"Pret: ");
		double y = Convert.ToDouble(Console.ReadLine());
	rez=x*y;
	Console.WriteLine("\t= "+rez);
	total += rez;
	Console.WriteLine("total acumulat: "+total);
		}
		Console.WriteLine("TOTAL: "+total);
	}
}
namespace PR2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Inventar inventar = new Inventar();
			inventar.calculeaza();
			Console.Write("Daca doriti sa continuati tastati litera y, daca nu n.");
			string continua = Console.ReadLine();
			switch(continua){
				case "y":
					inventar.calculeaza(); break;
				case "n":
					Console.ReadKey(true); Console.WriteLine("Apasati orice taste de doua ori pentru a iesi."); break;
			}
			Console.ReadKey(true);
		}
	}
}