using System;

namespace DrivingLicense
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm küsib kasutaja vanust
			//programm arvutab kasutaja vanust
			//kui kasutaja on noorem, kui 18, siis programm kuvab kosnoolis 
			// "oled liiga noor, et juhilube saada";
			//kui kasutaja on vanem, kui 18, siis programm kuvab konsoolis
			//oled piisavalt vana, et juhilube taodelda!";
			//kui kasutaja on 18, siis pogramm kuvab konsoolis
			//"palju õnne! Nüüd saad sa juhiluba taodelda"

			Console.WriteLine("Palun sisesta enda vanus:");
			int UserAge = Convert.ToInt32(Console.ReadLine());

			if (UserAge < 18)
			{
				Console.WriteLine("Oled liiga noor, et juhilube saada!");
			}
			else if (UserAge > 18)
			{
				Console.WriteLine("Oled piisavalt vana, et juhilube taodelda!");
			}

			else
			{
				Console.WriteLine("Palju õnne!" +
					" Nüüd saad sa juhilube taodelda!");
			}

			Console.WriteLine("Kena päeva Teile!");

		}
	}
}
