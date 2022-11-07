using System;
public struct Customer //Defining Structure Customer with some fields as private:
{
    private int _id;
    private string _name;

    public int ID // to access details we use get and set method
    {
        get { return _id; }
        set { _id = value; }
    }

    public string NAME
    {
        get { return _name; }
        set { _name = value; }
    }

    public Customer(int ID, string NAME) //Constructor build 
    {
        this._id = ID;
        this._name = NAME;
    }
    public void printdetails()// method definition to print the details
    {
        Console.WriteLine("User id is {0},\nUser name is {1}",this._id,this._name);
    }
}
class Structure
{
    public static void Main()
    {
        Customer C =new Customer(11550,"Ayush"); //cretae an object and assign the vlaues
        C.printdetails();   //call the method to print the details

    }
}