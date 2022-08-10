using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDePromedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MI PRIMERA APLIACION (10/08/2022)

            // DECLARAMOS LAS VARIABLES NECESARIAS

            int sumaDePromedios = 0;
            int puntajePromedioDeEstudiante;

            // INGRESAMOS LOS DATOS DEL ESTUDIANTE Y CANTIDAD DE MATERIAS

            Console.WriteLine("¡Buenos dias! Ingrese el nombre del estudiante: ");
            string nombreDeEstudiante = Console.ReadLine();
            Console.WriteLine("Ingrese cantidad de materias a" +
                " evaluar promedio: ");
            string cantidadDeMateriasIngresado = Console.ReadLine();

            // COMPROBAMOS SI EL VALOR INGRESADO ES UN NUMERO (POR EL MOMENTOS SOLO DEL TIPO "INT")

            bool cantidadDeMaterias = int.TryParse(cantidadDeMateriasIngresado, out int numCantidadDeMaterias); 
            int materias = numCantidadDeMaterias;

            if (cantidadDeMaterias)
            {
                for (int i = 1; i <= numCantidadDeMaterias; i++)
                {
                    // INGRESAMOS LOS PUNTAJES DE CADA MATERIA

                    Console.WriteLine("Ingrese el puntaje del alumno: ");
                    string puntajeDeEstudianteIngresado = Console.ReadLine();

                    // COMPROBAMOS SI EL VALOR INGRESADO ES UN NUMERO (POR EL MOMENTOS SOLO DEL TIPO "INT")

                    bool puntajeDeEstudiante = int.TryParse(puntajeDeEstudianteIngresado,
                       out int puntaje);

                    if (puntajeDeEstudiante && (puntaje <= 10 && puntaje >= 0))
                    {
                        Console.WriteLine("El valor ingresado es: " + puntaje);
                        sumaDePromedios += puntaje;
                    }
                    else
                    {
                        // AGREGAMOS UN LUGAR PARA REEMPLAZAR EL VALOR INGRESADO DE MANERA INCORRECTA
                        
                        numCantidadDeMaterias++;
                        puntaje = 0;
                        Console.WriteLine("El valor ingresado no es valido");
                    }
                }
            }

            // EL RESULTADO DEL PROMEDIO DE PUNTAJE DE CADA MATERIA

            puntajePromedioDeEstudiante = sumaDePromedios / materias;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("El promedio de {0} es {1}", nombreDeEstudiante, puntajePromedioDeEstudiante);

            Console.Read();
        }
    }
}
