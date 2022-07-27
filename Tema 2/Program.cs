//Tipos de datos y Variables

int i = 0;
float miFloat = i;//asi se convierte implicitamente, es decir automaticamente
long l = 1;

float f = 1.5555f;
double miDouble = f;
double d = 2.6666666d;

char c = 'c';
string str = "string";

//Convertir  manualmente
string miString = "32";
int miInt = Convert.ToInt32(miString);//asi se convierte manualmente un valor
Console.WriteLine(miString + miInt);


Console.WriteLine("int: " + i);
Console.WriteLine("long: " + l);
Console.WriteLine("float: " + f);
Console.WriteLine("double: " + d);
Console.WriteLine("c: " + c);
Console.WriteLine("string: " + str);


//valor Null
int? a = null;// hay que poner ? para que acepte null
Console.WriteLine(a.HasValue);//saber el valor
//No se puede sumarle nada a un valor NULL.

//Se puede inicializar una variable que no se sepa su valor en 0.
int b = 0;
Console.WriteLine(b);
//a = 12;
//Console.WriteLine(a);