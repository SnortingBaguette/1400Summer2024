using System;
					
public class Program
{
	public static void Main()
	{
		//Part 1
		string[] cars = {"Mustang", "Caemro", "HellCat", "Corvette", "Viper", "McCleran"};
		Console.WriteLine(cars.Length);
		foreach(var car in cars) 
		{
			Console.WriteLine("I love my " + car + ".");
		}
		
		//Part 2
		string[] playerTypes = {"Pawn", "Pawn", "Pawn"};
		
		for (var i = 0; i < playerTypes.Length; i++)
		{
			playerTypes[i] = "Queen";
		}
		
		foreach(var playerType in playerTypes)
		{
			Console.WriteLine(playerType);
		}
		
		//Part 3
		weapon[] weaponObjs = {new weapon(), new weapon()};
		weaponObjs[1].weaponName = "Sword";
		weaponObjs[1].weaponName = "Hammer";
		
		for(var i = 0; i < weaponObjs.Length; i++)
		{
			weaponObjs[i].powerLevel = 0;
		}
		
		
		foreach(var item in weaponObjs)
		{
			Console.WriteLine(item.weaponName);
			Console.WriteLine(item.powerLevel);
		}
		
		Console.Write("Enter a number: ");
		int enteredNumber = Convert.ToInt16(Console.ReadLine()); //Converts the input into a number
		int row = 0;
		for(int i = 1; i <= enteredNumber; i++) //Runs the loop while the i is less than the entered number
		{
			while (row < i) //Runs the loop while the row number is less than i
			{
				Console.Write(i); //Keeps writing i on the same string. I used WriteLine previously, and it was giving me a wrong result
				row++; //Counts the row number so it doesn't go over i
			}
			Console.WriteLine(""); //Moves on to the next row so it would look like a pyramid
			row = 0; //Resets the row value so it can be used again
		} 
	}
	
	public class weapon 
	{
		public string weaponName = "Axe";
		public int powerLevel = 1;
	}
	
	
}
