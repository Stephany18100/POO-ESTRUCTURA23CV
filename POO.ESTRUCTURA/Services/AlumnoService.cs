using POO.ESTRUCTURA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.ESTRUCTURA.Services
{
    public class AlumnoService
    {
        public Alumno Agregar ()


        {
			try
			{
                Alumno res = new Alumno()
                {
                    id = 1,
                    Nombre = "Majo",
                    Apellido = "sosa",
                    FechaIngreso = DateTime.Now,
                    Grado = 3,
                    Promedio = 9.5
                };
                return res;
            }
			catch (Exception ex)
			{

				throw new Exception("Sucedio un error" +ex.Message);
			}
        }


        public void Imprimir(Alumno request)
        {
            try
            {
                Console.WriteLine("El nombre es; " + request.Nombre);
                Console.WriteLine("El apellido es; " + request.Apellido);
                Console.WriteLine("La fecha de ingreso es; " + request.FechaIngreso);
                Console.WriteLine("El grado es; " + request.Grado);
            }
            catch (Exception ex)
            {

                throw new Exception("Sucedio un error" +ex.Message);
            }
        }
        #region-----Validar Aprobacion
        public bool ValidarProm(double num1)
        {
            bool validar=false;
            if(num1 > 7)
            {
                validar=true;
            }
            return validar;
        }
        #endregion
    }
}
