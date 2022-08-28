using System;
class HelloWorld {
  static void Main() {
    string name;
    
    name=Console.ReadLine();
    Console.WriteLine(name);
    
    int age=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(age);
    
    double Weight=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(Weight);
    
    int s=name.IndexOf('a');
    Console.WriteLine(s);
    
    string cut=name.Substring(s);
    Console.WriteLine(cut);
    
    cut=name.Substring(s,2);
    Console.WriteLine(cut);
    
    string up=name.ToUpper();
    string down=name.ToLower();
    
    Console.WriteLine(up);
    Console.WriteLine(down);
    
    
    
  }
}