using Humanizer;

Console.WriteLine("Por favor, ingrese un nombre");
string nombre = Console.ReadLine();

Console.WriteLine("Por favor, ingrese su cargo");
string cargo = Console.ReadLine();

Console.WriteLine("Por favor, ingrese su edad");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Hola, mi nombre es {nombre}, mi cargo es {cargo}, y tengo {edad.ToWords(new System.Globalization.CultureInfo("es"))} años.");