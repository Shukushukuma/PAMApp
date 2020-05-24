using System;
using System.Collections.Generic;

public class Person
{
    //Fields
    public int personid;
    public string name;
    public string lastname;
    public double cellnumber;
    public string address;

    //Properties
    public int PersonID {get;set;}
    public string Name {get; set;}
    public string LastName {get;set;}
    
    public double Cellnumber  {get;set;}

    public string Address 
    {
        get{return address;}//to remember this format
        set{address=value;}
    }

    //Constructor
    public Person(int pID, string pName, string lName, double cellNum, string pAddress)
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