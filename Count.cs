using System;

namespace Count
{
	class Program
	{
		static void Main (string[] args)
		{
			long Count = 0;
			long Sum = 0;
			double Avg = 0.0;
			long Big = long.MinValue;
			long Small = long.MaxValue;
			Console.WriteLine("Type Done To Show Results");
			while (true)
			{
				Console.WriteLine("Enter a Number");
				string a = Console.ReadLine();
				if (a.ToLower() == "done")
				{
					break;
				}
				Count += 1;
				Console.WriteLine(Count + " - " + a);
				long a2 = long.Parse(a);
				Sum += a2;
				Avg = Sum / Count;
				if (Big < a2)
				{
					Big = a2;
				}
				if (Small > a2)
				{
					Small = a2;
				}
			}
			Console.WriteLine("The Count is - " + Count);
			Console.WriteLine("The Sum is - " + Sum);
			Console.WriteLine("The Average is - " + Avg);
			Console.WriteLine("The Biggest Number is - " + Big);
			Console.WriteLine("The Smallest Number is - " + Small);
			
			Console.WriteLine(Environment.NewLine + "Type Anything To Quit");
			Console.ReadLine();
		}
	}
}
