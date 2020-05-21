using System;
using System.Collections.Generic;

public class List<Person>
{
    public int PersonID;
    public string Name;
    public string LastName;
    
    public double Cellnumber;

    public string Address;

    public void setPerson(int pID, string pName, string lName, double cellNum, string pAddress)
    {
        PersonID = pID;
        Name =pName;
        LastName=lName;
        Cellnumber=cellNum;
        Address=pAddress;

    }
    public Object getPerson (Person person)
    {
        return person;
    }
}