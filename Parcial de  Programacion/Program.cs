using System;
using System.Collections;

namespace Parcial_de__Programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStudents;
            ArrayList registro = new ArrayLits();
            string nombre;
            int edad;
            int contador = 0;
            Console.WriteLine("Ingrese la caltidad de estudiantes");
            numberStudents = int.Parse(Console.ReadLine());
            Console.WriteLine();

            {
                Console.WriteLine("Ingrse la Primera nota de laboratorio");
                double nota = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrse la segundo nota de laboratorio");
                double nota1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrse la del parcial nota");
                double nota2 = double.Parse(Console.ReadLine());


                if (nota >= 0 && <= 10)
                    if (nota >= 6)
                        Console.WriteLine("aprovado");

                    else if (nota >= 5)

                        Console.WriteLine("Reprobado");

            }


            while (contador < numberStudents)
            {
                Console.WriteLine("Ingrese el nombre del estudiante");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la Edad del estudiante");
                edad = int.Parse(Console.ReadLine());


                Students students = new Students() { Nombre = nombre, Edad = edad };

                registro.Add(students);

                contador++;
                {
                    Console.WriteLine("******Resulatdo*******");
                    for (int i = 0; i < registro.Count; i++)
                    {
                        Students st = (Students)registro[i];}
                }
                Console.Write(students.getData());
            }
        }

    }
    public class Students
    {  
           
    private string _nombre;
    private string _edad;


    public string Nombre
    {
        get => _nombre;
        set => _nombre = value;
    }

    public string Edad
    {
        get => _edad;
        set => _edad = value;
    }
    
   public string getData()
        {
            return "Nombre: " + _nombre + "edad: " + _edad;


        }
    }
}
