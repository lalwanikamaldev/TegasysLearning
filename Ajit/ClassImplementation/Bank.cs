using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassImplementation
{
    public class Bank
    {
        public string Country, State, City;
        protected int IFSC; //As this is proctected, IFSC can be used in Customer class also
        internal bool LockerAvailability; //As this is internal, it can be used within this assembly only
        
        //default Construtor 
        public Bank()
        {
            this.Country = "India";
            this.State = "Maharashtra";
            this.City = "Pune";
            this.IFSC = 123456;
            this.LockerAvailability = true;
        
        }

    }

    public class Customer:Bank
    {
        //ByDefault private so no need to use private keyword explicitly
        private int readonly _CustomerID, _AvailableBalance;
        string _CustomerName;
        bool _AccountStatus;

        //Parameterized Constructor
        public Customer(int CustomerID, int AvailableBalance, string CustomerName, bool AccountStatus)
        {
           int a= 5;
           _CustomerID = CustomerID;
            AvailableBalance = _AvailableBalance;
            CustomerName = _CustomerName;
            AccountStatus = _AccountStatus;
        }

        public int CustomerID
        {
            get { return _CustomerID; }
            
        }

        public int AvailableBalance
        {
            get { return _AvailableBalance; }
            set{ }
        }

        public string CustomeraName
        {
            get { return _CustomerName; }
            set { }
        }

        public bool AccountStatus
        {
            get { return _AccountStatus; }
            set { }
        }
    }



}

public class EngineClass {
 public virtual void TansformFuelToEnergy()
 {
  Console.WriteLine("I am in Engine class ");
  // engine related transformation generic (take fule and transform 
 }

 public void SmokeRelease()
 {
 // implementaton 
 
}
}

public class BikeEngine : EngineClass  {
// public void SmokeRelease()
// { // inharitance 
 // implementaton 
 
//}

 public override void TansformFuelToEnergy(int sa)
 {
 // logic which differ for BikeEngine 
   Console.WriteLine("I am in BikeEngine class ");
}
}

public class ActivaEngine :  EngineClass {
 public override void TansformFuelToEnergy(int sa)
 {
 // logic which differ for BikeEngine 
   Console.WriteLine("I am in BikeEngine class ");
}
}

public class Bike {
private readonly EngineClass _engine;

public Bike(EngineClass engineClassObject)
{
_engine = engineClassObject;  //myactiva
}
// anywhere 
_engine => myactiva .


}

public class Activata {
public BikeEngine Engine {get;set;}
}

main()
{
BikeEngine mybike = new BikeEngine();
mybike.TansformFuelToEnergy(); // what output it is giving 
EngineClass engine = new BikeEngine();
engine.TansformFuelToEnergy(); // that output  it is giving 
ActivaEngine myActiva = new ActivaEngine();
mybike.TansformFuelToEnergy(); // what output it is giving 

Bike bike = new Bike(myActiva);
bike myBike = new Bike(mybike);


public Customer(int CustomerID, int AvailableBalance, string CustomerName, bool AccountStatus)

Customer customer = new Customer(33,346,"Kamal", true);
    
    
}
