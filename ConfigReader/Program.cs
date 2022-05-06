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

			dynamic cfgR = new CfgReader(filename);

			Console.WriteLine(cfgR.ToString());

			
			//Console.WriteLine("cc = " + cfgR.cc);
			//cfgR.cc = 100.3f;
			//Console.WriteLine("cc = " + cfgR.cc);

			//Console.WriteLine("Variabili importate:");
			//Console.WriteLine(cfgR.DumpEntries());

			//Console.WriteLine("Linee:");
			//Console.WriteLine(cfgR.DumpLines());

			Console.WriteLine("Fine programma.");
			Console.ReadKey();
			}
		}
	}
