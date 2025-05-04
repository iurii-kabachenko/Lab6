using System;

class Rectangle
{
    
    private double a;
    private double b;

    public Rectangle()
    {
        a = 0;
        b = 0;
    }

   
    public double A
    {
        get { return a; }
        set { a = value; }
    }

    public double B
    {
        get { return b; }
        set { b = value; }
    }

    
    public bool Correct()
    {
        return a > 0 && b > 0;
    }

    
    public double Area()
    {
        return a * b;
    }

    
    public double Perimeter()
    {
        return 2 * (a + b);
    }

    
    public void Print()
    {
        Console.WriteLine($"Сторона a = {a}, сторона b = {b}");
    }
}


class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Rectangle rect = new Rectangle();

        
        Console.Write("Введіть сторону a: ");
        double inputA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть сторону b: ");
        double inputB = Convert.ToDouble(Console.ReadLine());

        
        rect.A = inputA;
        rect.B = inputB;

        
        rect.Print();

        
        if (rect.Correct())
        {
            Console.WriteLine($"Площа прямокутника: {rect.Area()}");
            Console.WriteLine($"Периметр прямокутника: {rect.Perimeter()}");
        }
        else
        {
            Console.WriteLine("Неможливо створити прямокутник із заданими сторонами (сторони мають бути > 0)");
        }
    }
}
