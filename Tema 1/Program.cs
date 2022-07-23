
Console.WriteLine("Introduce tu nombre:");
string nombre = Console.ReadLine();//Esto lee y guarda lo que el usuario escribe
//Console.WriteLine("Hola, " + nombre);

//Edad?
Console.WriteLine("Introduce tu edad:");
int edad = int.Parse(Console.ReadLine());

//Ciudad
Console.WriteLine("Introduce tu ciudad:");
string ciudad = Console.ReadLine();

//Presentar mensaje "Hola, NOMBRE. Tienes AÑOS. Vives en Ciudad.
Console.WriteLine("Hola, " + nombre + ". Tienes " + edad + " años. Vives en " + ciudad);

