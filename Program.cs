//written by nicolas
//1/28
//The Triangle Farmer


using System.Security.Cryptography.X509Certificates;

public class AreaCalculator
{
    private double triangleBase = -1;
    private double triangleHeight = -1;

    //gets and sets
    public double TriangleBase
    {
        get{return this.triangleBase;}
        set{this.triangleBase = value;}
    }
    public double TriangleHeight
    {
        get{return this.triangleHeight;}
        set{this.triangleHeight = value;}
    }
    //full constructor
    public AreaCalculator(double _triangleBase, double _triangleHeight)
    {
        triangleBase = _triangleBase;
        triangleHeight = _triangleHeight;

    }
    // empty constructor
    public AreaCalculator() : this(-1, -1) {}

    public double FindArea(double triangleBase, double triangleHeight)
    {
        return (triangleBase * triangleHeight)/2;
    }

    public override string ToString()
    {
        return $"Area : {FindArea(this.TriangleBase, this.TriangleHeight)} square units\n";
    }
    public static void Main()
    {
        Console.WriteLine("What is the triangle's base?");
        double triangleBase = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Whate is the triangle's height?");
        double triangleHeight = Convert.ToDouble(Console.ReadLine());

        AreaCalculator triangle = new AreaCalculator(triangleBase, triangleHeight);
        Console.WriteLine(triangle);
    }
}
