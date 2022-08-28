using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World"+"\n"+ "My name is tanvir Ahmmed,"+"\t"+ "Age :"+ (20+5) );
    
    int i=12;
    float f=12.5F;  // f/F or D/d not problem;
    double d=23.00D;
    string str="Tanvir";
    Console.WriteLine(i + f + d + str);
    Console.WriteLine(i +"\t"+ f +"\t"+  d +"\t"+ str);
    Console.WriteLine(i+1 +"\t"+ f+1F +"\t"+  d+1D +"\t"+ str);
    Console.WriteLine(i+1 +"\t"+ (f+1) +"\t"+  (d+1) +"\t"+ str);
    Console.WriteLine(i+1 +"\t"+ (f+1D) +"\t"+  (d+1F) +"\t"+ str);
    Console.WriteLine(i+1 +"\t"+ (f+1F) +"\t"+  (d+1d) +"\t"+ str);
    Console.WriteLine(i +"\t"+ f +"\t"+ (d+5D) +"\t"+ str);
  }
}