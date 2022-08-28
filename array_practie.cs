using System;
using System.Linq;
using System.Collections.Generic;
public class Hello {
	public static void Main() {
		int[] arr={91,4,7,11,1,3,84,87,92,33,22,14};
		
		// for(int i=1;i<arr.Length;i++)
		// {
		// 	int temp=arr[i];
		// 	int j=i-1;
			
		// 	while(j>=0 && arr[j]>temp)
		// 	{
		// 		arr[j+1]=arr[j];
		// 		j--;
				
		// 	}
			
		// 	arr[j+1]=temp;
		// }
		
		Array.Sort(arr);// Quicek sort Algorithom use O(nlogn);
		
		Array.Reverse(arr);
		
		for(int i=0;i<arr.Length;i++)
		{
			Console.Write(arr[i]+"\t");
		}
		
		Console.WriteLine("\n"+arr.Max()+"\n"+arr.Min()+"\n"+arr.Sum());
		
	    double sum=arr.Sum(),avg=0;
	    
	    avg=sum/arr.Length;
	    
	    Console.WriteLine("\n"+avg);
	    
		
		
	}
}
