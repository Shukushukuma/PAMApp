using System;
using System.Collections.Generic;

namespace PAMApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var addressList = new List<Person>();
            Person Mawande = new Person(1,"Mawande","Mnukwa",0730780495,"09 Sussex Road,Observatory,7395,Cape Town");

            Console.WriteLine(Mawande.Address);


        }
    }
}
