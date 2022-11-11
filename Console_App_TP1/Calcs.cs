using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace Console_App_TP1
{
    public class Calcs
    {
        enum Dia {Domingo=1,Lunes=2,Martes=3,Miercoles=4,Jueves=5,Viernes=6,Sabado=7}
        static void Main(string[] args)
        {
        }

        // Ejercicio 1
                
        public static int Sumar(int a, int b)
        {
            return a + b;

        }


        // Ejercicio 2

        public static string cadenacortada(string cadena)
        {

            string resultado = cadena.Substring( 0, cadena.Length - 4 );
            return resultado;


        }


        // Ejercicio 3
        public static string quehoraes()
        {
            string hora = DateTime.Now.ToString("dd-MM-yy hh:mm");

            return hora;
        }




    }
}
