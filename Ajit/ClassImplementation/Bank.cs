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
        
        //Parameterless Construtor
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
        int _CustomerID, _AvailableBalance;
        string _CustomerName;
        bool _AccountStatus;

        //Parameterized Constructor
        public Customer(int CustomerID, int AvailableBalance, string CustomerName, bool AccountStatus)
        {
            CustomerID = _CustomerID;
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
