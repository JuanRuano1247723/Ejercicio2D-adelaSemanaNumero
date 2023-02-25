using System;

namespace Ejercicio2DíadelaSemanaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            inicio:
            Console.WriteLine("Ejercicio 2: Día de la semana según un número");
            Console.WriteLine("Escriba un número entre el 1 y el 7: ");
            bool convertido = int.TryParse(Console.ReadLine(), out int n1);
            if (convertido == true && (n1 <= 7 && n1 >= 1))
            {
                goto convertir;
            }
            else
            {
                Console.WriteLine("Error: El número a ingresar debe estar contenido entre 1 y 7");
                goto inicio;
            }

            convertir:
            switch (n1)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;

                case 2:
                    Console.WriteLine("Martes");
                    break;

                case 3:
                    Console.WriteLine("Miercoles");
                    break;

                case 4:
                    Console.WriteLine("Jueves");
                    break;

                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Error: El número a ingresar debe estar contenido entre 1 y 7");
                break;
            }
        }
    }
}
