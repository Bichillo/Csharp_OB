//Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.
Console.WriteLine("Ingrese su nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Me has confirmado que te llamas: " + nombre);

Console.WriteLine("Ingrese su apellido: ");
string apellido = Console.ReadLine();
Console.WriteLine("Me has confirmado que te apellidas: " + apellido);

Console.WriteLine("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine());

Console.WriteLine("Sabes programar? escribe si o no: ");
string sabeProgramar = Console.ReadLine();

if (sabeProgramar == "si") 
{
    Console.WriteLine("Has dicho que SI");
}
else if (sabeProgramar == "no")
{
    Console.WriteLine("Has dicho que NO");
}
else
{
    Console.WriteLine("Respuesta INCORRECTA, por favor responde 'si' o 'no'");
}
//-----------------------------------------------------FIN EJERCICIO 1-------------------------------------------------

//Usando los tipos de variables más adecuados, describe los objetos siguientes:
//Coche: puertas, ruedas, marca, ITV vigente
//Mesa: peso, largo, material, color




