using System;
namespace TestAssociationJuly2018
{
    /*partial*/ class Address //adding partial to the front allows for multiple people to work on files
    {
        //need to encapsulate all below in a diff class for associaion
        //properties
        public string StreetNo { set; get; }
        public string ZipCode { set; get; }
        public string StreetName { set; get; }

        //constructor to take those values
        public Address(string strNo, string zip, string strName)
        {
            StreetNo = strNo;
            ZipCode = zip;
            StreetName = strName;
        }
    }
}
