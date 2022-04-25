using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CfgReader
	{
	internal class Program
		{
		static void Main(string[] args)
			{
			string filename = "esempio.txt";
			Console.WriteLine("Avvio programma.");

			CfgReader cfgR = new CfgReader(filename);
			cfgR.Process();

			Console.WriteLine(cfgR.ToString());

			Console.WriteLine("Variabili importate:");
			Console.WriteLine(cfgR.DumpEntries());

			Console.WriteLine("Fine programma.");
			Console.ReadKey();
			}
		}
	}
