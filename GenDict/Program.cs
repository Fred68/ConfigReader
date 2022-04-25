
#define DYN_DICTIONARY			// Use ctor: dynamic GenDictionary(); instead of GenDictionary GenDictionary();


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenDict
	{
	internal class Program
		{
		static void Main(string[] args)
			{
			Console.WriteLine("Start");

			try
				{

				#if DYN_DICTIONARY
				dynamic d = new GenDictionary();
				#else
				GenDictionary d = new GenDictionary();
				#endif
				
				
				d["i"] = 100;

				#if DYN_DICTIONARY
				d.i = 110;				// Only available with dynamic GenDictionary()
				#endif
				
				d["s"] = "pippo";
				d["b"] = true;
				d["f"] = 1.2f;
				d["d"] = 1.3d;
				
				// d["err"] = DateTime.Now;			// Eccezione, tipo non ancora implementato
				
				d["e"] = new DateTime(2022,4,21,19,15,35);

				d["il"] = new List<int>(new int[] {1,2,3});
				d["sl"] = new List<string>(new string[] {"a","b","c"});
				d["bl"] = new List<bool>(new bool[] {true,false});
				d["fl"] = new List<float>(new float[] {1.1f, 1.2f, 1.3f});
				d["dl"] = new List<double>(new double[] {1.1d, 1.2d, 1.3d});
			
				d["s"] = d["s"] + " modificato";

				Console.WriteLine(d["i"]);
				Console.WriteLine(d.i);
				Console.WriteLine(d["s"]);
				Console.WriteLine(d["b"]);
				Console.WriteLine(d["f"]);
				Console.WriteLine(d["d"]);
				Console.WriteLine(d["e"]);

				Console.WriteLine(d["il"]);
				Console.WriteLine(d["sl"]);
				Console.WriteLine(d["bl"]);
				Console.WriteLine(d["fl"]);
				Console.WriteLine(d["dl"]);

				d["d"] = null;
				// Console.WriteLine(d["d"]);		// Eccezione (d cancellato)

				Console.WriteLine("Count:");
				Console.WriteLine(d.Count);
				

				Console.WriteLine("Keys from KeyCollection():");
				foreach(string ss in d.KeyCollection)
					{
					Console.WriteLine(ss);
					}
				#if !DYN_DICTIONARY
				List<string> keylist = d.KeyCollection.ToList();
				#endif
				
				// Console.WriteLine(d.Values);		// Eccezione (non implementato)

				string s = "d";
				Console.WriteLine($"ContainsKey({s}): {d.ContainsKey(s)}");


				Console.WriteLine("Keys from IEnumerator<string> GetEnumerator():");
				foreach(string k in d)
					{
					Console.WriteLine(k);
					}
				
				#if !DYN_DICTIONARY
				Console.WriteLine("Keys from IEnumerable<string> Keys():");
				foreach(string k in d.Keys())
					{
					Console.WriteLine(k);
					}
				#endif

				Console.WriteLine("Dump");
				Console.WriteLine(d.Dump());

				}

			catch (Exception ex)
				{
				Console.WriteLine(ex.Message);
				}
			
			Console.WriteLine("End");
			Console.ReadKey();
			}
		}
	}
