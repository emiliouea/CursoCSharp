using FigurasGeometricas;

try
{
    Console.WriteLine("=== DEMOSTRACIÓN DE FIGURAS GEOMÉTRICAS ===\n");

    // Demostración con un círculo
    Console.WriteLine("--- CÍRCULO ---");
    var circulo = Circulo.Create(5.0);
    Console.WriteLine(circulo);

    // Modificar radio y mostrar nuevamente
    circulo.Radio = 7.5;
    Console.WriteLine($"Después de cambiar el radio a 7.5:");
    Console.WriteLine(circulo);

    Console.WriteLine("\n--- RECTÁNGULO ---");
    // Demostración con un rectángulo
    var rectangulo = Rectangulo.Create(4.0, 6.0);
    Console.WriteLine(rectangulo);

    // Modificar base y altura y mostrar nuevamente
    rectangulo.BaseRectangulo = 8.0;
    rectangulo.Altura = 3.0;
    Console.WriteLine($"Después de cambiar base a 8.0 y altura a 3.0:");
    Console.WriteLine(rectangulo);

    Console.WriteLine("\n--- CUADRADO (Rectángulo especial) ---");
    // Demostración de cuadrado como caso especial de rectángulo
    var cuadrado = Rectangulo.Create(5.0, 5.0);
    Console.WriteLine(cuadrado);
}
catch (ArgumentException ex)
{
    // Manejo de errores específicos de validación
    Console.WriteLine($"Error: {ex.Message}");
}
catch (Exception ex)
{
    // Manejo de errores inesperados
    Console.WriteLine($"Error inesperado: {ex.Message}");
}

Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();
