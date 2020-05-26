using System;
using System.Collections.Generic;

namespace PAMApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string[] addressList = new string[10];
            Person Mawande = new Person(1,"Mawande","Mnukwa",0730780495,"09 Sussex Road,Observatory,7395,Cape Town");
            //addressList = Mawande.getPerson();
            

            
            foreach(string item in Mawande)
            {
                Console.WriteLine(item);
            }
            
            //Console.WriteLine(addressList[Mawande]);
            Mawande.getPerson();

            


        }
    }
}
