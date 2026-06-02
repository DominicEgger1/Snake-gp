/*
 * Created by SharpDevelop.
 * User: egger
 * Date: 27.02.2025
 * Time: 09:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Addition_Einlesen
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			//Neu
			//Datentyp: String
			
			String zahl1Strg;
			String zahl2Strg;
			
			
			//Variablen zum rechen
			int zahl1;
			int zahl2; 
			int ergebniss;
			
			Console.WriteLine("Das Programm berechnet die Summe zweier Zahlen die über die Tastatur eingelesen wurden");
			Console.Write("Gib die erste Zahl ein:");
			zahl1Strg    =   Console.ReadLine();
			Console.Write("Gib die zweite Zahl ein:");
		    zahl2Strg    =   Console.ReadLine();
		    //Umwandlung (Konvertierung) der eingegebenen Text in eine Zahl.
		    zahl1   =   Convert.ToInt32(zahl1Strg);
		    zahl2   =   Convert.ToInt32(zahl2Strg);
		    //Addieren
		    ergebniss = zahl1 + zahl2;
		    Console.WriteLine(zahl1+"+"+zahl2+"="+ergebniss);
			
				
			
			
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}