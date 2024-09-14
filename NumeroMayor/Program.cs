namespace Ejercicio02;

class Program
{
    static void Main (string[] args) 
    {
        //variables del programa
        int a, b, c;
        do
        {
            Console.WriteLine("Ingrese primer numero: ");
            a =  int.Parse(Console.ReadLine()!);

            Console.WriteLine("Ingrese el segundo numero: ");
            b = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Ingrese tercer numero :");
            c = int.Parse(Console.ReadLine()!);

            if (a > b && a > c)
            {
                Console.WriteLine($"El numero mayor es: {a}.");
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine($"El numero mayor es: {b}.");
                }
                else
                {
                    Console.WriteLine($"El numero mayor es: {c}.");
                }
            }

           
        } while (true);
    
    }
}
