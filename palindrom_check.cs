using System;
using System.Linq;
public class Hello {
	public static void Main() {
		
		int x=Convert.ToInt32(Console.ReadLine());
		
		int palindrome=0,temp=x,mod;
		
		while(x>0)
		{
			mod=x%10;
			palindrome=(palindrome*10)+mod;
			x=x/10;
			
			
		}
		if(temp==palindrome)
		{
			Console.WriteLine("true");
			
		}
		else
		{
			Console.WriteLine("false");
			
		}
	}
}
