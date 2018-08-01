using System;

namespace TestAssociationJuly2018
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();

            Employee e2 = new Employee();

            e1.HomeAddress.StreetName = "Woodward"; //go to Address and give that employee the value "Woodward"

            Console.WriteLine(e1.HomeAddress.StreetName);
        }
    }
}
