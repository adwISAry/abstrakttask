using abstrakt;

Console.WriteLine("1.Square" + "\n2.Rectangular" + "\nQuit");

Figure figure;   
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 0:
        break;
        case 1:
        figure = new Square(0);
        int a = figure.CalcArea();
        
        if( a == -1)
        {
            break;
        }
        Console.WriteLine(a);

        break;
            case 2:
        figure = new Rectangle(-5,7);
        int b = figure.CalcArea();
        if( b == -2)
        {
            break;
        }
        Console.WriteLine(b);
        break;
}
