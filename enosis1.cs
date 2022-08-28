
using System;
using System.Linq;
using System.Collections.Generic;


namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
       int l1,l2;
       l1=Convert.ToInt32(Console.ReadLine());
       l2=Convert.ToInt32(Console.ReadLine());
       
       List<int> first= new List<int>();
       List<int> second= new List<int>();
       
       while(l1!=0)
       {
       	int mod=l1%10;
       	 first.Add(mod);
       	 l1=l1/10;
       }
       
       while(l2!=0)
       {
       	 int mod=l2%10;
       	 second.Add(mod);
       	 l2=l2/10;
       }
       
       int firstLen=first.Count;
       int secondLen=second.Count;
       
       first.Sort();
       second.Sort();
       
  
       
       int c=0;
       
       if(firstLen==secondLen)
       {
         for(int i=0;i<firstLen;i++)
         {
         	if(first[i]!=second[i])
         	{
         		Console.WriteLine("false");
         		c=1;
         		break;
         	}
         }
       }
       else
       {
       	Console.WriteLine("false");
       	c=1;
       	
       }
       
       
       if(c==0)
       {
       	Console.WriteLine("true");
       }
       
       
       
       //Console.WriteLine(firstLen+"  "+secondLen);
       
       
    }
  }
}