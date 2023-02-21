// Alexander Raptis, Feb 20th 2023

using System;

// base Class 
class Animal
{
    private string name; // only accessible within this class
    protected string type; //accessible from derived classes
    public string color;  // accessible from any class

    public void setName(string name)
    {
        this.name = name;
    }
    public virtual string getName()
    {
        return this.name;
    }
    public void setType(string type)
    {
        this.type = type;
    }
    public virtual string getType()
    {
        return this.type;
    }
}

class Goose : Animal
{
    public double weight;
    public double age;
    public decimal price;
    public override string getName()
    {
        return base.getName();
    }
    public override string getType()
    {
        return type;
    }
}

class Program
{
    static public void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        myAnimal.setType("Mammal");
        myAnimal.setName("Richard");
        myAnimal.color = "Black";

        Console.WriteLine("Animal info");
        Console.WriteLine("Name: {0}", myAnimal.getName());
        Console.WriteLine("Type: {0}", myAnimal.getType());
        Console.WriteLine("Color: {0}", myAnimal.color);

        Goose myGoose = new Goose();
        myGoose.weight = 9;
        myGoose.age = 3;
        myGoose.price = 40.00M;
        myGoose.setName("Henry");
        myGoose.setType("Bird");
        myGoose.color = "White";

        Console.WriteLine("Goose info");
        Console.WriteLine("Name: {0}", myGoose.getName());
        Console.WriteLine("Type: {0}", myGoose.getType());
        Console.WriteLine("Color: {0}", myGoose.color);
        Console.WriteLine("Price: {0}", myGoose.price);
        Console.WriteLine("Age: {0}", myGoose.age);
        Console.WriteLine("Weight (lb): {0}", myGoose.weight);

    }
}