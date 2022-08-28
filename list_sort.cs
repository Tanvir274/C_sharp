using System;
 
 
 
using System.Collections.Generic;
 
 
 
class sort_example
 
{
 
 
 
    static void Main()
 
    {
 
        List<int> sort_list = new List<int>();
 
        sort_list.Add(11);
 
        sort_list.Add(31);
 
        sort_list.Add(5);
 
        sort_list.Add(7);
 
        sort_list.Add(9);
 
        sort_list.Add(15);
 
        sort_list.Add(1);
 
        sort_list.Add(3);
 
 
 
        System.Console.WriteLine("List Before");
 
 
 
        foreach (int num in sort_list)
 
        {
 
            System.Console.WriteLine(num);
 
        }
 
        //Now sorting the list
 
        sort_list.Sort();
 
 
 
 
 
        System.Console.WriteLine("\n" + "List After" + "\n");
 
 
 
        foreach (int num in sort_list)
 
        {
 
            System.Console.WriteLine(num);
 
        }
 
 
 
        Console.ReadLine();
 
    }
 
 
 
}

