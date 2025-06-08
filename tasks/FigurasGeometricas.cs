/*
 * Archivo: FigurasGeometricas.cs
 * Estudiante: Senguana Wisuma Emilio Yankuam
 * Fecha: 07 de Junio de 2025
  * Descripción: Implementación de clases para figuras geométricas con encapsulación
 * de tipos de datos primitivos y métodos para cálculo de área y perímetro.
 */


namespace FigurasGeometricas;

// Clase que representa un círculo con encapsulación y validación del radio
public class Circulo
{
    // Campo privado para almacenar el valor del radio
    private double radio;

    // Constructor privado para forzar el uso del método Create con validación
    private Circulo(double radio) => Radio = radio;

    // Método estático para crear un círculo validando el radio
    public static Circulo Create(double radio)
    {
        if (radio <= 0)
            throw new ArgumentException("El radio debe ser mayor a 0");
        return new Circulo(radio);
    }

    // Propiedad pública para obtener y establecer el radio con validación
    public double Radio
    {
        get => radio;
        set => radio = value > 0
            ? value
            : throw new ArgumentException("El radio debe ser mayor a 0");
    }

    // Método que calcula el área del círculo: π * r^2
    public double CalcularArea() => Math.PI * radio * radio;

    // Método que calcula el perímetro del círculo: 2 * π * r
    public double CalcularPerimetro() => 2 * Math.PI * radio;

    // Método para representar el círculo como cadena con valores formateados
    public override string ToString() =>
        $"Círculo - Radio: {radio:F2}, Área: {CalcularArea():F2}, Perímetro: {CalcularPerimetro():F2}";
}

// Clase que representa un rectángulo con encapsulación y validación de base y altura
public class Rectangulo
{
    // Campos privados para base y altura
    private double baseRectangulo;
    private double altura;

    // Constructor privado que utiliza las propiedades para asignar valores validados
    private Rectangulo(double baseRect, double altura)
    {
        BaseRectangulo = baseRect;
        Altura = altura;
    }

    // Método estático para crear un rectángulo validando base y altura
    public static Rectangulo Create(double baseRect, double altura)
    {
        if (baseRect <= 0)
            throw new ArgumentException("La base debe ser mayor a 0");
        if (altura <= 0)
            throw new ArgumentException("La altura debe ser mayor a 0");
        return new Rectangulo(baseRect, altura);
    }

    // Propiedad para base con validación al asignar
    public double BaseRectangulo
    {
        get => baseRectangulo;
        set => baseRectangulo = value > 0
            ? value
            : throw new ArgumentException("La base debe ser mayor a 0");
    }

    // Propiedad para altura con validación al asignar
    public double Altura
    {
        get => altura;
        set => altura = value > 0
            ? value
            : throw new ArgumentException("La altura debe ser mayor a 0");
    }

    // Método que calcula el área del rectángulo: base * altura
    public double CalcularArea() => baseRectangulo * altura;

    // Método que calcula el perímetro del rectángulo: 2 * (base + altura)
    public double CalcularPerimetro() => 2 * (baseRectangulo + altura);

    // Método para representar el rectángulo como cadena con valores formateados
    public override string ToString() =>
        $"Rectángulo - Base: {baseRectangulo:F2}, Altura: {altura:F2}, Área: {CalcularArea():F2}, Perímetro: {CalcularPerimetro():F2}";
}
