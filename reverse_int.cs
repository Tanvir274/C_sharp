using System;
using System.Linq;
using System.Collections.Generic;
public class Hello {
	public static void Main() 
	{
		int num=7234567;
		
		int rev=0;
		
		while(num>0)
		{
			rev=rev*10+(num%10);
			num=num/10;
		}
		
		Console.WriteLine(rev);
	}
}
