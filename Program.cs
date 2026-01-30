using System;
using System.Threading.Tasks;

namespace randomProgram
{
    class Program
    {
 

    static void Main(string[] args)
    {

      mostrarBienvenida();
        

    }

    static async Task mostrarBienvenida()
    {
        Console.WriteLine(@"
      __________________________________________________________
     /                                                          \
    |    _   _   _   _   _   _   _   _   _   _   _   _   _   _   |
    |   / \ / \ / \ / \ / \ / \ / \ / \ / \ / \ / \ / \ / \ / \  |
    |  ( S | Y | S | T | E | M |   | V | I | S | I | O | N | | ) |
    |   \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/  |
     \__________________________________________________________/
        ");


        // Información de la aplicación
        Console.WriteLine(" ===========================================================");
        Console.WriteLine($"   Versión: 1.0.0");
        Console.WriteLine($"   Usuario: {Environment.UserName}");
        Console.WriteLine($"   Fecha:   {DateTime.Now:dd/MM/yyyy HH:mm}");

        Console.WriteLine(" ===========================================================");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n [SISTEMA CARGADO CORRECTAMENTE]");
            //limpia la consola despues de 2 segundos
            await Task.Delay(2000);

            Console.Clear();

            menuPrincipal();
        }

    static void menuPrincipal()
    {
        
        int opcion = 0;
        Console.WriteLine(@"
      __________________________________________________________
     /                                                          \
    |    _   _   _   _   _   _   _   _   _   _   _   _   _   _   |
    |   / \ / \ / \ / \ / \ / \ / \ / \ / \ / \ / \ / \ / \ / \  |
    |  ( S | Y | S | T | E | M |   | V | I | S | I | O | N ) | | |
    |   \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/ \_/  |
     \__________________________________________________________/
        ");

         Console.WriteLine("\n [MENÚ PRINCIPAL]"); 
         Console.WriteLine(" Opción 1: Sumar");
         Console.WriteLine(" Opción 2: contar hasta tu edad");
         Console.WriteLine(" Opción 3: Salir");

        while (opcion < 1 || opcion > 3)
        {
            Console.Write("Ingrese su opción (1-3): ");
            opcion = Convert.ToInt32(Console.ReadLine());
        }

        switch (opcion)
        {
            case 1:
                Console.Clear();
                Console.WriteLine(@"Has seleccionado sumar. ");
                    Sumar();
                    break;
            case 2:
                Console.Clear();
                Console.WriteLine(@"Vamos a contar hasta la edad que tienes");
                    ContarEdad();
                    break;
            case 3:
                Console.Clear();
                Console.WriteLine("\n Saliendo del programa. ¡Hasta luego!");
                break;
        }
        Console.WriteLine("\n Presiona Enter para volver al menú principal...");
        Console.ReadLine();

        Console.Clear();
        menuPrincipal();

    }

    static void Sumar()
    {
        double num1, num2, suma;
        char realizarOtraSuma;

        Console.Write("Ingrese el primer número: ");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        suma = num1 + num2;

        Console.WriteLine($"\n La suma de {num1} y {num2} es: {suma}");
        Console.WriteLine("Desea realizar otra suma? (s/n): ");
        realizarOtraSuma = Console.ReadLine()[0];

        if (realizarOtraSuma.ToString().ToLower() == "s")
        {
            Console.Clear();
            Sumar();
        }
        else if (realizarOtraSuma.ToString().ToLower() == "n")
        {
            Console.Clear();
            menuPrincipal();
        }
        else
        {
            Console.WriteLine("Opción no válida. Escriba 's' para sí o 'n' para no.");
            Console.Clear();

        }
      }
        static void ContarEdad()
            {
            int edad;
            Console.Write("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n Contando hasta {edad}:");

            for (int i = 1; i <= edad; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}