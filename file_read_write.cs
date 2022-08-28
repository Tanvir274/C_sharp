using System;
using System.IO;
public class Hello {
	public static void Main() {
		
		string[] writeText={"hello My name is Tanvir Ahmmed","i have 10 taka"};
		File.WriteAllLines("first.txt",writeText);
	
		
		
		
		
		//string readText= File.ReadAllText("first.txt");
		
		string[] readText= File.ReadAllLines("first.txt");
		
		foreach(string i in readText)
		{
			System.Console.WriteLine(i);
			
		}
	
		
	}
}
