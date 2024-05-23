using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("This is a Temperature Adviser! Please insert the temperature in degrees Celsius:");
		int temperature = Convert.ToInt32(Console.ReadLine());
		
		if (temperature >= 30) {
			Console.WriteLine("Stay hydrated and avoid staying in the sun for too long!");
			
		} else if (temperature >= 20 && temperature < 30) {
			Console.WriteLine("Enjoy the pleasant weather!");
			
		} else {
			Console.WriteLine("Please wear warm clothes!");
		}
		
		
		
		
		Console.WriteLine("Please insert your score for grading:");
		int score = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Please insert your grading subject (English, Science, Math, Engineering):");
		string subject = Console.ReadLine();
		if (score >= 90) {
			Console.WriteLine("You have an A");
			if (subject == "Math" || subject == "math") {
				Console.WriteLine("I see the letters don't confuse you, don't they?");
			} else if (subject == "Science" || subject == "science") {
				Console.WriteLine("Now you've scientifically proven yourself.");
			} else if (subject == "English" || subject == "english") {
				Console.WriteLine("I bet you're good at writing convinsing excuses for skipping school.");
			} else if (subject == "Engineering" || subject == "engineering") {
				Console.WriteLine("Engineer TF2");
			}
		} else if (score >= 80 && score < 90) {
			Console.WriteLine("You have a B");
			if (subject == "Math" || subject == "math") {
				Console.WriteLine("You've almost got it.");
			} else if (subject == "Science" || subject == "science") {
				Console.WriteLine("That plant was refusing to grow.");
			} else if (subject == "English" || subject == "english") {
				Console.WriteLine("That word was hard to spell.");
			} else if (subject == "Engineering" || subject == "engineering") {
				Console.WriteLine("You haven't engi-neared your limit yet, try better next time.");
			}
		}
		else if (score >= 70 && score < 80) {
			Console.WriteLine("You have a C");
			if (subject == "Math" || subject == "math") {
				Console.WriteLine("Lost a '-' somewhere in there?");
			} else if (subject == "Science" || subject == "science") {
				Console.WriteLine("I see you didn't wear the goggles when mixing salt and water?");
			} else if (subject == "English" || subject == "english") {
				Console.WriteLine("The teacher told you to read the directions several times.");
			} else if (subject == "Engineering" || subject == "engineering") {
				Console.WriteLine("I see you didn't put a pen behind your ear.");
			}
		}
 		else if (score >= 60 && score < 70) {
			Console.WriteLine("You have a D");
			if (subject == "Math" || subject == "math") {
				Console.WriteLine("Looks like math is not your stong suit.");
			} else if (subject == "Science" || subject == "science") {
				Console.WriteLine("Looks like the apple did not fall after all...");
			} else if (subject == "English" || subject == "english") {
				Console.WriteLine("Speling?");
			} else if (subject == "Engineering" || subject == "engineering") {
				Console.WriteLine("You're not allowed near the computers now.");
			}
		} else {
			Console.WriteLine("You have an F");
			if (subject == "Math" || subject == "math") {
				Console.WriteLine("If you cound all the homeless people in your city, you can safely add one to that, since you'll join them soon.");
			} else if (subject == "Science" || subject == "science") {
				Console.WriteLine("Go synthesize yourself a better grade.");
			} else if (subject == "English" || subject == "english") {
				Console.WriteLine("U r in need of studying.");
			} else if (subject == "Engineering" || subject == "engineering") {
				Console.WriteLine("No blueprints? Yeah, I ate them all, watcha gonna do about it?");
			}
		}
	}
}
