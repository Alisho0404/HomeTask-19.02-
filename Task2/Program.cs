
var rectangle = new Rectangle();
Console.Write("Width = "); 
rectangle.Width = int.Parse(Console.ReadLine());
Console.Write("Height = ");
rectangle.Height = int.Parse(Console.ReadLine());
Console.WriteLine("Area = "+rectangle.Area());

class Rectangle
{
    public double Width; 
    public double Height;  
    public double Area()
    {
        return Width * Height;
    }
}