int X = 20;
int Y = 13;
double N = 8.5;
double M = 4.7;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($" Las variables son : \n " +
    $"X = {X} \n " +
    $"Y = {Y} \n" +
    $" N = {N} \n" +
    $" M= {M} ");
Console.ResetColor();
Console.WriteLine("------------------------------------------------------------------------------------------------------------------ ");

int suma;
suma = X + Y;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("La suma de ambos numeros es : " + suma);
Console.ResetColor();

Console.WriteLine(" ");

int diferencia;
diferencia = X - Y;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("La diferencia es de : " + diferencia);
Console.ResetColor();

Console.WriteLine(" ");

int pruducto;
pruducto = X * Y;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("El producto de ambos numeros son : " + pruducto);
Console.ResetColor();

Console.WriteLine(" ");

int cociente;
cociente = X / Y;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("El producto de ambos numeros son : " + cociente);
Console.ResetColor();


Console.WriteLine(" ");

int resto;
resto = X % Y;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("El resto de ambos numeros son : " + resto);
Console.ResetColor();

Console.WriteLine("------------------------------------------------------------------------------------------------------------------ ");

Double Suma;
Suma = N + M;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("El resto de N y M : " + Suma);
Console.ResetColor();

Console.WriteLine(" ");

Double Diferencia;
Diferencia = N - M;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("La diferencia de N y M  : " + Diferencia);
Console.ResetColor();

Console.WriteLine(" ");

Double Producto;
Producto = N * M;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("El producto de N y M  : " + Producto);
Console.ResetColor();

Console.WriteLine(" ");

Double Cociente;
Cociente = N / M;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("El cociente de N y M  : " + Cociente);
Console.ResetColor();

Console.WriteLine(" ");

Double Resto;
Resto = N % M;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("El resto de N y M  : " + Resto);
Console.ResetColor();

Console.WriteLine("------------------------------------------------------------------------------------------------------------------ ");

Double Suma1;
Suma1 = X + N;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("La suma de X y N : " + Suma1);
Console.ResetColor();

Console.WriteLine(" ");

Double Cociente1;
Cociente1 = Y / M;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("El cociente de Y y M  : " + Cociente1);
Console.ResetColor();

Console.WriteLine(" ");

Double Resto1;
Resto1 = Y % M;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("El resto de Y y M  : " + Resto1);
Console.ResetColor();

Console.WriteLine("------------------------------------------------------------------------------------------------------------------ ");

Double DobleX, DobleY, DobleN, DobleM;
DobleX = X * 2;
DobleY = Y * 2;
DobleN = N * 2;
DobleM = M * 2;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"El doble de X es {DobleX} \n" + $"El doble de Y es {DobleY} \n" + $"El doble de N es {DobleN} \n" + $"El doble de M es {DobleM}");

Double SumaDeTodasLasVariables;
SumaDeTodasLasVariables = X + Y + M + N;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("La suma de todas las variables es : " + SumaDeTodasLasVariables);
Console.ResetColor();

Double ProductoDeTodasLasVariables;
ProductoDeTodasLasVariables = X * Y * M * N;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("El producto de todas las variables es : " + ProductoDeTodasLasVariables);
Console.ResetColor();

Console.WriteLine("------------------------------------------------------------------------------------------------------------------ ");
