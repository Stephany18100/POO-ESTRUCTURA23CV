using POO.ESTRUCTURA.Entities;
using POO.ESTRUCTURA.Services;
using System;

namespace POO.ESTRUCTURA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlumnoService servicio = new AlumnoService();

            AlumnoService alumno=new AlumnoService();
            Alumno alumno1 = alumno.Agregar();
            alumno.Imprimir(alumno1);

            Console.WriteLine("La calificacion es " +servicio.ValidarProm(alumno1.Promedio));

            
            
        }
    }
}
