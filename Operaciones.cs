public class Operaciones : IOperaciones
{
    public double CalcularAreaCirculo(double radio) => Math.PI * Math.Pow(radio, 2);

    public double CalcularAreaRectangulo(double largo, double ancho) => largo * ancho;

    public double CalcularVolumenCubo(double lado) => Math.Pow(lado, 3);

    public double CalcularPerimetroCuadrado(double lado) => 4 * lado;

    public double CalcularVolumenEsfera(double radio) => (4 / 3) * Math.PI * Math.Pow(radio, 3);

    public void Imprimir()
    {
        Console.WriteLine("Resultados de las operaciones:");
        Console.WriteLine($"Área del círculo: {CalcularAreaCirculo(5)}");
        Console.WriteLine($"Área del rectángulo: {CalcularAreaRectangulo(4, 6)}");
        Console.WriteLine($"Volumen del cubo: {CalcularVolumenCubo(3)}");
        Console.WriteLine($"Perímetro del cuadrado: {CalcularPerimetroCuadrado(7)}");
        Console.WriteLine($"Volumen de la esfera: {CalcularVolumenEsfera(4)}");
    }
}
