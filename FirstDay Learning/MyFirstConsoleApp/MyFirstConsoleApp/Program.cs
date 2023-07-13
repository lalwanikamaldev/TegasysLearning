internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // syntex 
        // operators 
        // basic class writting 
        // modifiers 
        // Condistional statement 
       
        // for loop
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        List<string> names = new List<string>
        {
            "Ajit",
            "Ashar"
        };
        //foreach 
        foreach(var name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("Is Ashar Join Today?"); // Y Ashar , N,xz Ajit )

        var input = Console.ReadLine();

        // conditional operator 
        var outputPrint = input == "Y" ? "Ashar" : "Ajit";
        Console.WriteLine(outputPrint);


        // while loop 

        // do while loop 

        // switch case 
        // if , if eles
    }
}

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

// Mobile 

// Iphone : Mobile => 

// Android =>  Samsung , Redmi 




// class is a blueprint of object 

// object of Bike/activa/car/ (Create a bike)

public class Vehicle 
{
    
    public string Color {get;set;}
    
    public int EngineNumber {get;set;}
    
    public int Speed {get;set;}
    
    public void Accelerate()
    {
        // Accelerate , car bike 
    }
    
   
    //
    public void start()
    {
        
    }
    
    // function 
    public void stop()
    {
        
    }
}
}

class Activa : Vehicle
{
    
}

class Car : Vehicle 
{
    public string Color {get;set;}
    
    public int EngineNumber {get;set;}
    
    public int Speed {get;set;}
    
    public void Accelerate()
    {
        // Accelerate , car bike 
    }
    
   
    //
    public void start()
    {
        
    }
    
    // function 
    public void stop()
    {
        
    }
    public void GearChanger()
    {
        
    }
    
    public void Abs()
    {
        
    }
    
    public void HandBreak()
    {
        
    }
    
    public void CloseOpenDoor()
    {
    }
     
}



public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello Mono World");
    }
}
