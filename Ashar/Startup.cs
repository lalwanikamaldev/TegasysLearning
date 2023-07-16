using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Mobile
    {
        public int RAM { get; set; }
        public int ROM { get; set; }

        public string Color { get; set; }

        public string Manufacturer { get; set; }


        public void Price()
        {

        }

    }

    public class Android : Phone
    {
        static void Main()
        {

            Android 13 = Android();
        }

    }


    public class Windows : Phone
    {
        static void Main()
        { 
        Windows 8 = Windows();
    }
}

     
    public class iPhone : iPhon
    { 

       static void Main()
    {
            iPhone 14 = iPhone();

        }
    }




