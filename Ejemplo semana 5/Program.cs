using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int Id;
            String Código;
            String Nombre;
            int Edad;

            Console.WriteLine("Cuantos registros desea agregar:");
            int registros = int.Parse(Console.ReadLine());

            Estudiantes[] arregloestudiantes = new Estudiantes[registros];


            for (int i = 0; i < registros; i++)
            {
                Id = i + 1;
                Console.WriteLine("Ingrese los siguientes datos:");
                Console.WriteLine("Ingrese el Código:");
                Código = Console.ReadLine();
                Console.WriteLine("Ingrese el Nombre:");
                Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad:");
                Edad = int.Parse(Console.ReadLine());

                arregloestudiantes[i] = new Estudiantes(Id, Código, Nombre, Edad);
            }

            // REALIZAR CONSULTAS
            int con = 1;
            
            while (con == 1)
            {
                int datoint,op;
                string dato;

                Console.WriteLine(" por favor digite 1 si decea hacer una cosulta por edad, 2 si decea hacerla id y 3 si la decea por nombre ");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {

                    Console.WriteLine("digite apartir de que rango decea buscar la edad ");
                    datoint = int.Parse(Console.ReadLine());

                    IEnumerable<Estudiantes> consultaestudiantes = from estudiante in arregloestudiantes
                                                                   where estudiante.Edad >= datoint
                                                                   select estudiante;
                    Console.WriteLine("El resultado de la consulta es:");
                    foreach (Estudiantes consulta in consultaestudiantes)
                    {
                        Console.WriteLine(consulta.mostrar());

                    }

                }

                else if (op == 2)
                {

                    Console.WriteLine("digite el id que busca ");
                    datoint = int.Parse(Console.ReadLine());

                    IEnumerable<Estudiantes> consultaestudiantes = from estudiante in arregloestudiantes
                                                                   where estudiante.Id == datoint
                                                                   select estudiante;
                    Console.WriteLine("El resultado de la consulta es:");
                    foreach (Estudiantes consulta in consultaestudiantes)
                    {
                        Console.WriteLine(consulta.mostrar());

                    }
                }
                else if (op == 3)
                {


                    Console.WriteLine("digite apartir de que rango decea buscar la edad ");
                    dato = Console.ReadLine();

                    IEnumerable<Estudiantes> consultaestudiantes = from estudiante in arregloestudiantes
                                                                   where estudiante.Nombre == dato
                                                                   select estudiante;
                    Console.WriteLine("El resultado de la consulta es:");
                    foreach (Estudiantes consulta in consultaestudiantes)
                    {
                        Console.WriteLine(consulta.mostrar());

                    }


                }
                Console.WriteLine("digite 1 si decea consultar nuevamente y cualquier otro numero si no ");
                con = int.Parse(Console.ReadLine());

            }


            
            Console.Read();

        }
        
    }    
           
}
