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
a = 12;
Console.WriteLine(a);