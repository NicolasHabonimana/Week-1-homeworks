// Written by Nicolas
// 1/28

using System;

public class Clocktower
{
    // Class variable
    private int number = -1;
    // Gets & Sets
    public int Number
    {
        get {return this.number;}
        set {this.number = value;}
    }
    // Full constructor
    public Clocktower(int _number)
    {
        number = _number;
    }

    // Empty constructor
    public Clocktower() : this(-1) {}

    // Methods
    public string TickOrTock()
    {
        if(number % 2 == 0)
        {return "tik";}
        else
        {return "tok";}
    }

    public override string ToString()
    {
        return TickOrTock();
    }

    public static void Main()
    {
        Console.WriteLine("Enter a number to power the clock:");
        int input = Convert.ToInt32(Console.ReadLine());

        Clocktower clock = new Clocktower(input);
        Console.WriteLine(clock);
    }
}
