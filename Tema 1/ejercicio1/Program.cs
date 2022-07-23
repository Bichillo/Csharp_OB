//-------------------------------EJERCICIO 1----------------

//Escribe un programa que reciba tu nombre y lo escriba por consola.

Console.WriteLine("Como te llamas?:");
string nombre = Console.ReadLine();
Console.WriteLine(nombre);


//-------------------------------EJERCICIO 2-------------------------------

//Escribe un programa que tome la hora y la escriba por pantalla.

string hora = DateTime.Now.ToString("HH:mm:ss");
Console.WriteLine(hora);


//-----------------------------------------PRACTICA ADICIONAL-----------------------------------
DateTime holita = DateTime.Now;
Console.WriteLine(holita.ToString("f"));
