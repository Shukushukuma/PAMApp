# PAMApp
People Address Management Application

Coding Stardards
 - Class Design
  - Class name is title case i.e. Person
  - Field names start with underscore i.e. _name and they are private
  - Property names start with capital leters i.e. Name and they are public
  - Parameter names are camel cased i.e. personId
 
Properties vs Fields
 - The advantage of properties is that we can put logic here when someone updates this value.
   - Validate the that the value you're about to set is in the correct format
   - Notify another system that this Property is has been changed.   
   - Log an entry into database logger to track who/when it was update.
