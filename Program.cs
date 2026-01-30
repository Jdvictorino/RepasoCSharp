using System;
using System.Threading.Tasks;

namespace randomProgram
{
    class Program
    {
 

    static void Main(string[] args)
    {

        mostrarBienvenida();
        Thread.Sleep(3000);
        Console.Clear();
        menuPrincipal();
      


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
        Console.WriteLine("\n [Cargando.... Espere...]");
        
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
         Console.WriteLine(" Opción 2: Contar hasta tu edad");
         Console.WriteLine(" Opción 4: Adivina el numero");
         Console.WriteLine(" Opción 3: Salir");

        while (opcion < 1 || opcion > 4)
        {
            Console.Write("Ingrese su opción (1-4): ");
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
            case 4:
                    Console.Clear();
                Console.WriteLine(@"Has seleccionado adivina el numero.");
                    AdivinaElNumero();
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
            Console.WriteLine("\n Has terminado de contar.");
            Console.WriteLine ("Quiere contar otra vez? (s/n): ");
            char contarOtraVez = Console.ReadLine()[0];
            if (contarOtraVez.ToString().ToLower() == "s")
            {
                Console.Clear();
                ContarEdad();
            }
            else if (contarOtraVez.ToString().ToLower() == "n")
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
      static void AdivinaElNumero()
      {
          bool RespuestaCorrecta = false;
          int numeroSecreto = new Random().Next(1, 25);

            while (!RespuestaCorrecta)
            {
                Console.Write("Adivina el número secreto entre 1 y 25: ");
                int intento = Convert.ToInt32(Console.ReadLine());
                if (intento < numeroSecreto)
                {
                    Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
                }
                else if (intento > numeroSecreto)
                {
                    Console.WriteLine("Demasiado alto. Intenta de nuevo.");
                }
                else
                {
                    Console.WriteLine("¡Felicidades! Has adivinado el número secreto.");
                    RespuestaCorrecta = true;
                }
            }


          Console.WriteLine("Funcionalidad de Adivina el número aún no implementada.");
          Console.WriteLine("Presiona Enter para volver al menú principal...");
          Console.ReadLine();
          Console.Clear();
          menuPrincipal();
      }

    }
}