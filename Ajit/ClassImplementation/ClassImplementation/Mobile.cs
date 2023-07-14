using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassImplementation
{
    public class Mobile
    {
        public int SimCard {get; set;}
        public int BatteryCapacity { get; set; }

        public double Dimensions { get; set;}
        public double Screensize { get; set;}
        
        public string OperatingSystem { get; set;}

        public string Color { get; set;}

        public void Budget()
        {

        }
       
    }

    public class Android : Mobile
    {
        static void Main()
        {
            Android A1 = new Android();
            
            
            
        }
        
       
    } 
    
    public class iPhone:Mobile
    {
        static void Main()
        {
            iPhone i1 = new iPhone();
            
        }
  
    }
}
