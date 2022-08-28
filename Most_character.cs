using System;
using System.Linq;
using System.Collections.Generic;
public class Hello {
	public static void Main() {
		
		string str="Taaabbbbbbbbbbvir";
		
		int[] cha=new int[26];
		
		for(int i=0;i<26;i++)
		{
			cha[i]=0;
			
		}
		
		str.ToLower();
		
		for(int i=0;i<str.Length;i++)
		{
			if(str[i]>='a' && str[i]<='z')
			{
				cha[str[i]-'a']++;
				
			}
		}
		
		int most=0;
		char ch='a';
		
		for(int i=0;i<26;i++)
		{
			if(cha[i]>most)
			{
				most=cha[i];
				ch=Convert.ToChar(97+i);
				
			}
			
		}
		
		Console.WriteLine(most+"\t"+ch);
		
	}
}
