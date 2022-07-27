//Operadores
//Aritmeticos: + - * % ++ --

int i = 0;
Console.WriteLine("Suma: " + (i + 1));
Console.WriteLine("Autoincrmento: " + ++i);
Console.WriteLine("Autodrecremento: " + --i);
Console.WriteLine("Division: " + i / 4);

//-----------------------------------Ejercicio por cuenta propia--------------------------
//for (int j = 0; j < 10; j++);
//{
//  Console.WriteLine(j+1);//Para que el contador empiece desde 1. Si no pongo esto empieza a contar desde 0.
//}
//-------------------------------fin-----------------------------------------------

//Operadores logicos -> && || !
int a = 9;
int b = 11;
//Y - AND
Console.WriteLine("AND - Y");
Console.WriteLine("True True: " + (a < 10 && b > 10));
Console.WriteLine("False True: " + (a > 10 && b > 10));
Console.WriteLine("True False: " + (a < 10 && b < 10));
Console.WriteLine("False False: " + (a > 10 && b < 10));

//O - OR
Console.WriteLine("o - OR");
Console.WriteLine("True True: " + (a < 10 || b > 10));
Console.WriteLine("False True: " + (a > 10 || b > 10));
Console.WriteLine("True False: " + (a < 10 || b < 10));
Console.WriteLine("False False: " + (a > 10 || b < 10));

//NO - NOT
Console.WriteLine("NO - NOT");
Console.WriteLine("True: " + !(a < b));
Console.WriteLine("False: " + !(a > b));

