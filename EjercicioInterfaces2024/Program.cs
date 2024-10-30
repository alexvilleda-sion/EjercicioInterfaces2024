class Program
{
    static void Main(string[] args)
    {
        Operaciones operaciones = new Operaciones();

        Console.WriteLine("Ingrese el radio del círculo:");
        double radioCirculo = double.Parse(Console.ReadLine());
        Console.WriteLine($"Área del círculo: {operaciones.CalcularAreaCirculo(radioCirculo)}");

        Console.WriteLine("Ingrese el largo del rectángulo:");
        double largo = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el ancho del rectángulo:");
        double ancho = double.Parse(Console.ReadLine());
        Console.WriteLine($"Área del rectángulo: {operaciones.CalcularAreaRectangulo(largo, ancho)}");

        operaciones.Imprimir();
    }
}
