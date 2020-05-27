# PAMApp
People Address Management Application

Coding Stardards
 - Class Design
  - Class name is title case i.e. Person
  - Field names start with underscore i.e. _name and they are private
  - Property names start with capital leters i.e. Name and they are public
  - Parameter names are camel cased i.e. personId
 


public double Cellnumber
    {
        get{return _cellnumber;}//to remember this format
        set
        {
         //The advantage of properties is that we can put logic here when someone updates this value
         //e.g. Notify another system/event that this Property has been changed by. 
        
          _cellnumber=value;
          
          //another example is to Log an entry into database logger to track who/when it was update

        }
    }
