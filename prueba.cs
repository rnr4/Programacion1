using System;
					
public class Program
{
	public static void Main()
	{
		int a = 2;
		int b = 4;
		int c = 1;
		
		Console.WriteLine("A={0} | B={1} | C={2}",a,b,c);
		
		Console.WriteLine("------------------------");
		
		Console.Write("Organización AACB: ");
		Console.Write(a);
		Console.Write(a);
		Console.Write(c);
		Console.WriteLine(b);
		
		Console.WriteLine("------------------------");
		
		Console.Write("Organización BCA: ");
		Console.Write(b);
		Console.Write(c);
		Console.WriteLine(a);
		
		Console.WriteLine("------------------------");

		Console.Write("Organización BCBC: ");
		Console.Write(b);
		Console.Write(c);
		Console.Write(b);
		Console.WriteLine(c);
	}
}