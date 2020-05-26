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
    public int PersonID
    {
        get{return _personid;}
        set{_personid=value;}
    }
    public string Name
    {
        get{return _name;}
        set{_name=value;}
    }
    public string LastName
    {
        get{return _lastname;}//to remember this format
        set{_lastname=value;}
    }
    
    public double Cellnumber
    {
        get{return _cellnumber;}//to remember this format
        set{_cellnumber=value;}
    }

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
    public void getPerson ()
    {
        Console.WriteLine($" {PersonID.ToString()} {Name} {LastName} {Cellnumber.ToString()} {Address}");
    }

}