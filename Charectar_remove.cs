using System;
using System.Linq;
using System.Collections.Generic;
public class Hello {
	public static void Main() 
	{
		string str="Hello Tanvir";
		
		for(int i=str.Length-1;i>=0;i--)
		{
			if(str[i]=='l')
			{
				str=str.Remove(i,1);
			}
			
		}
		
		
		
		Console.WriteLine(str);
	
	}
}
