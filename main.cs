using System;

class MainClass {
  public static void Main (string[] args) {
  	int a;
  	int b;
  	int c;

  	Console.WriteLine("Enter the first number");
    a = Convert.ToInt32(Console.ReadLine()); 
    	Console.WriteLine("Enter the second  number");
    b = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Enter the third number");
    c = Convert.ToInt32(Console.ReadLine());
    if (a>b&&a>c){
  	Console.Write(a + " is the smallest number");
       }
             
 if (c<a&&c<b){
		Console.Write(c + " is the smallest number");
	}
else if ( b<a&&b<c){
	Console.Write( b + "is the smallest number");
	
	}
else if (a==b&&b==c){
	Console.Write( a +" is the smallest number ");
}
else if (a<b&&a<c){
	Console.Write(a + " is the smallest number");
}
}
}