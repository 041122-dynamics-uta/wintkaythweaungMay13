using System;
using System.Text;
using System.Data;


namespace  Model
{
    public class Customer
    {
        public int customerID {get;set;} = -1;
        public string fName {get;set;}
        public string  lname{get;set;}
        public string  username{get;set;}
        public string password{get;set;}
        public string address{get;set;}
        public string Email {get;set;}

        private string _phone;
        public string phone 
        {
            get {return _phone;}
            set
            { int v = _phone.Length;
                if (v == 10)
                {
                    _phone=value;
                }
                else 
                {
                throw new Exception("Phone number can't have more or less than 10 digits");
                }
        
            }

        }
        public List<Order>Orders
        {
            get {return _order;}
            set{_order =value;}
        }

        public Customer()
        {
            fName= "";
            lname="";
            username="";
            password="";
            address="";
            Email="";
            _phone ="   ";
            _order=new List<Order>()
            {
                new Order()
            };
            
        }
        public override string ToString()
        {
            return $"ID:{memeberID}\nFristName: {fName}\nLastName : {lname}\nEmail:{Email}\nAddress:{address}\nPhone :=1{phone}";
        }
    }
    
}