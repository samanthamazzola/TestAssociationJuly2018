using System;
namespace TestAssociationJuly2018
{
    public class Employee
    {
        //properties
        public string FullName { set; get; }
        //using the properties to get what's in that class and apply it 
        //Address is part of the Employee; class association
        public Address HomeAddress { set; get; }

        //constructor
        public Employee()
        {
            //Object of that Address class!!!
            HomeAddress = new Address("", "", ""); //
            FullName = "Not assigned"; 
        }
    }
}
