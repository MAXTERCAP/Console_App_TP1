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
        enum Dias {Domingo=1,Lunes=2,Martes=3,Miercoles=4,Jueves=5,Viernes=6,Sabado=7}
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


        // Ejercicio  4 y 5


        // Comentario de una sola línea

        /**
         * Comentario de varias líneas
         */




        //  Ejercicio Enumeraciones 1 y 2

        public static string DiasSemana(int i)
        {
            Dias dia = (Dias)i;
            return "Hoy es día " + dia.ToString();
        }




        //  Ejercicio Conversiones 1


        public static bool Conver_V_F(int a)
        {
            return Convert.ToBoolean(a);
        }



        //  Ejercicio Conversiones 2

        public static bool BoolParseado(string a)
        {
            return bool.Parse(a);
        }



        //  Ejercicio Conversiones 3

        public static bool Parseado(string a)
        {
            return bool.TryParse(a, out bool resultado);
        }






        //  Ejercicio Casteo 1

        public static int ConvertirDoubleAInt(double a)
        {
            return (int)a;
        }



        //  Ejercicio Casteo 2

        public static decimal ConvertirIntADecimal(int a)
        {
            return a;
        }


        //  Ejercicio Casteo 3
        public static short ConvertirIntAShort(int a)
        {
            return (short)a;
        }





    }
}
