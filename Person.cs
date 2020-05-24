using System;
using System.Collections.Generic;

public class Person
{
    //Fields
    private int _personid;
    private string _name;
    private string _lastname;
    private double _cellnumber;
    private string _address;

    //Properties
    public int PersonID {get;set;}
    public string Name {get; set;}
    public string LastName {get;set;}
    
    public double Cellnumber  {get;set;}

    public string Address 
    {
        get{return _address;}//to remember this format
        set{_address=value;}
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