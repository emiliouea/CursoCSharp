using CursoCSharp;
 
Persona persona = new Persona();
persona.crearPersona("Emilio", 25, "06-06-2000");
Console.WriteLine($"Nombre: {persona.Nombre}");
Console.WriteLine($"Edad: {persona.Edad}");
Console.WriteLine($"Fecha Vencimiento: {persona.FechaNacimiento}");
