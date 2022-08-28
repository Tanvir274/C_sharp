using System;

public class Example
{
	public static void Main()
	{
		string[] arr = { "Sort", "Array", "C#" };

		Array.Sort(arr);

		Console.WriteLine(String.Join(", ", arr));
	}
}