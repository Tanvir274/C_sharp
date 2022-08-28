using System;
using System.Linq;
using System.Collections.Generic;
public class Hello {
	public static void Main() {
		
		string str="Video provides a powerful way to help you prove your point.";
		int max=0;
		List<char> list=new List<char>();
		for(int i=0;i<str.Length;i++)
		{
			if(str[i]==' ' || i==str.Length-1)
			{
				max=Math.Max(max,list.Count);
				
				list.Reverse();
				
				foreach(char j in list)
				{
					System.Console.Write(j);
					
				}
				System.Console.Write(" ");
				
				list.Clear();
			}
			else
			{
				list.Add(str[i]);
			}
		}
		
		
		System.Console.WriteLine("\n"+max);
	}
}
