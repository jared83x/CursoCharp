//Programa que verifica si un numero es par o impar.

namespace Ejercicio01;
class Program
{
    static void Main (string[] args)
    {
        int numero;
        string? dato = string.Empty;

        do 
        {
             
           Console.Write("Ingrese un numero entero o S para salir: ");
           dato = Console.ReadLine();
               
               
           if (dato.ToLower() == "s")
           {
                continue;
           }
                     
            if ( int.TryParse(dato, out numero))
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"El numero {numero}, es par.");
                }
                else
                {
                    Console.WriteLine($"El numero {numero}, es impar.");
                }

            }
            else
            {
                Console.WriteLine($"Lo que ingresaste:{numero} no es un numero entero...");
            }

            
            
        }while (dato.ToLower() != "s");

        Console.WriteLine("Programa terminado...");

    }

    //Procedimiento para pedir datos
    static void PadirDatos()
    {
        Console.WriteLine("Escribe un numero entero: ");
    }

}
