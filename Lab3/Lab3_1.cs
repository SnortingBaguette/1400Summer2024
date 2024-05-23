using System;
					
public class Program
{
	public Operations myOperator;
	
	public void Main()
	{
		myOperator = new Operations();
		
		Console.WriteLine("Welcome");
		myOperator.DoMath(10, 4);
		myOperator.DoMath(20, 7);
		myOperator.DoMath(30, 15);
		myOperator.Compare(5, 0);
		myOperator.Compare(2, 7);
		myOperator.CheckPassword("stscsd");
		myOperator.CheckPassword("OU#12");
	}
}

public class Operations {
	public void DoMath(int value, int value2)
	{
		var number = value + value2;
		Console.WriteLine(number);
	}
	
	public void Compare (int value, int value2)
	{
		if(value > value2)
		{
			Console.WriteLine("True, the first is greater");
		} else
		{
			Console.WriteLine("False, the second is greater");
		}
	}
	
	public void CheckPassword (string password)
	{
		if (password == "OU#12")
		{
			Console.WriteLine("Correct password");
		} else
		{
			Console.WriteLine("Incorrect Passowrd");
		}
	}
}
