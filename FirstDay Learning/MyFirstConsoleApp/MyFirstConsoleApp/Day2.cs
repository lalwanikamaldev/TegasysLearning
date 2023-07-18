using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{



public class Program
{
    private static void Main(string[] args)
    {
        Windows 8 = Windows();
        Android android13 = new Android();

         Android android15 = new Android(16); // integer 
    //    android13.OS = "Android";
      // android13.IsUsbDubuggingEnabled = true; // compilaion error
       android13.EnableUsbDebugging(); 
       android13.RAM = 20;

       android13.SetUsbDebugging(true); // first fucntion which take bool input 
       android13.SetUsbDebugging(13); //second function which take int input 

    }
}

    public class Mobile
    {
        public int RAM { get;  set; } // property 
        public RamType = "MobileRam"; // field
        public int ROM { get; set; }

        public string Color { get; set; }

        public string Manufacturer { get; set; }

        public string OS { get; set; }


        public void Price()
        {
                  
        }

           public void SetUsbDebugging(bool debuggingValue)
        {
            IsUsbDubuggingEnabled = debuggingValue;
            Rooting();
        }

        

    }


 // polimorphism 

 1. overloading (static polimorphism)
 2. overriding (run time polimorphism)






    public class Android : Phone
    {
        
        // //constructor creation
        Public Android()
        {
            this.RAM = 8;
            this.OS = "Android";
              // no setup 
        }

         // //parametrize constructor creation
        Public Android(int ram)
        {
            this.RAM = ram;
            this.OS = "Android";
              // no setup 
        }
        
        private bool IsUsbDubuggingEnabled {get;set;}
       // private bool AndroidRoot {get;set;}

       

         public void SetUsbDebugging(int versionOfAndoid)
        {
            if(versionOfAndoid > 12)
                IsUsbDubuggingEnabled = true;
            Rooting();
        }

      



        private void Rooting() // Private protected / public 
        {

        }

    }


    public class Windows : Phone
    {
   
   }

     
    public class iPhone : iPhon
    { 


    }


public class Main
{

}


// use All the access modifier in Class creation and Also use the interitance 5 accessmodifer  
// Create the constructor paramerize/non paramertrized 
// overloading function to use in class

