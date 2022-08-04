Coordenadas misCoordenadas = new Coordenadas(5,6,4);
Console.WriteLine("x: " + misCoordenadas.X);
Console.WriteLine("y: " + misCoordenadas.Y);
Console.WriteLine("z: " + misCoordenadas.Z);

Coordenadas misCoordenas2 = misCoordenadas with { Z = 3, X = 2};
Console.WriteLine(misCoordenas2);

public struct Coordenadas
{
    public Coordenadas(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public override string ToString() => $"({X}, {Y}, {Z})";
}

