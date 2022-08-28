using System;
using System.Linq;
using System.Collections.Generic;
public class Hello {
	public static void Main() 
	{
		LinkedList<int> list= new LinkedList<int>();
		
		list.AddLast(5);
		list.AddLast(11);
		list.AddLast(7);
		list.AddLast(14);
		list.AddLast(2);
		list.AddLast(11);
		list.AddLast(21);
		list.AddLast(155);
		list.AddLast(52);
		
		foreach(int i in list)
		{
			Console.WriteLine(i);
		}
		
		list.Remove(list.First);
		
		 //var newNode = list.AddLast(3);
      
         //list.AddBefore(newNode, 7);
		
		 System.Console.WriteLine("After remove 7");
		
		foreach(int i in list)
		{
			Console.WriteLine(i);
		}
		
		System.Console.WriteLine("After sort");
		
		List<int> lllst= new List<int>(list);
		
		lllst.Sort();
		
		foreach(int i in lllst)
		{
			Console.WriteLine(i);
		}
		
		
		
		
	}
}
