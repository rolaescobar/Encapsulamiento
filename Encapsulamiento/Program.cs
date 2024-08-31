
using Encapsulamiento;

Persona persona = new Persona();

persona.SetNombre("Rolando");
Console.WriteLine("Nombre inicial: " + persona.GetNombre());

Console.WriteLine("Edad inicial:" + persona.GetEdad());

persona.Cumpleanos();
Console.WriteLine("Edad despues del cumpleanos:"+persona.GetEdad());

persona.SetNombre("Kevin");
Console.WriteLine("Nombre despues del cambio a :"+persona.GetNombre());