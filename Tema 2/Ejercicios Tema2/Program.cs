//Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.
Console.WriteLine("Ingrese su nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Me has confirmado que te llamas: " + nombre);

Console.WriteLine("Ingrese su apellido: ");
string apellido = Console.ReadLine();
Console.WriteLine("Me has confirmado que te apellidas: " + apellido);

Console.WriteLine("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine());
Console.WriteLine("Me has confirmado que tienes: " + edad);

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
    Console.WriteLine("Respuesta INCORRECTA");
}
//-----------------------------------------------------FIN EJERCICIO 1-------------------------------------------------

//Usando los tipos de variables más adecuados, describe los objetos siguientes:
//Coche: puertas, ruedas, marca, ITV vigente

string coche = "Opel Astra";
int puertas = 5;
int ruedas = 4;
string marca = "Opel";
bool itv = true;


//Mesa: peso, largo, material, color

string mesa = "Escritorio";
double peso = 10.5d;
double altura = 1.35d;
string material = "madera";
string color = "negro";








//------------------------Ejercicio 3------------------------------
//Determina los operadores para verificar las siguientes condiciones:
//Un número es mayor o igual a 18

int num = 18;
        if (num >= 18)
        {
            Console.WriteLine("Es mayor o igual a 18");
        }
        else
        {
            Console.WriteLine("Es menor a 18");
        };


//Un char es ‘a’
char a = 'a';
Type char1 = a.GetType();
Type char2 = typeof(char);
bool comparacion = (char1 == char2);
Console.WriteLine(comparacion);


//Se cumplen dos conciones a la vez (ambas verdaderas)
int num1 = 10;
int num2 = 20;
bool condicion1 = (num1 >= 5 && num2 >= 15);
Console.WriteLine(condicion1);



//Se cumple una de dos condiciones a la vez (una true y otra false)
bool condicion2 = (num1 >= 12 || num2 >= 15);
Console.WriteLine(condicion2);

