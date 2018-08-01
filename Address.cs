using System;
namespace TestAssociationJuly2018
{
    public class Address
    {
        //need to encapsulate all below in a diff class for associaion
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
