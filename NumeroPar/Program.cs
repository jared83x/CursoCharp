//Programa que verifica si un numero es par o impar.

namespace Ejercicio01;
class Program
{
    static void Main (string[] args)
    {
        do 
        {
            int n;
            Console.Write("Ingrese un numero: ");

            n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine($"El numero {n}, es par.");
            }
            else
            {
                Console.WriteLine($"El numero {n}, es impar.");
            }

            
        }while (true);
        
    }

    //Procedimiento para pedir datos
    static void PadirDatos()
    {
        Console.WriteLine("Escribe un numero entero: ");
    }

}
