using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace Console_App_TP1
{
    enum Dias { Domingo = 1, Lunes = 2, Martes = 3, Miercoles = 4, Jueves = 5, Viernes = 6, Sabado = 7 }
    public enum Color { Blanco, Azul, Negro }

    public class Calcs
    {
        

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


        //6

        //  Ejercicio Enumeraciones 1 y 2

        public static string DiasSemana(int i)
        {
            Dias dia = (Dias)i;
            return "Hoy es día " + dia.ToString();
        }


        //7

        //  Ejercicio Conversiones 1


        public static bool Conver_V_F(int a)
        {
            return Convert.ToBoolean(a);
        }


        //8

        //  Ejercicio Conversiones 2

        public static bool BoolParseado(string a)
        {
            return bool.Parse(a);
        }


        //9

        //  Ejercicio Conversiones 3

        public static bool Parseado(string a)
        {
            return bool.TryParse(a, out bool resultado);
        }


        //10

        //  Ejercicio Casteo 1

        public static int ConvertirDoubleAInt(double a)
        {
            return (int)a;
        }


        //11

        //  Ejercicio Casteo 2

        public static decimal ConvertirIntADecimal(int a)
        {
            return a;
        }


        //12

        //  Ejercicio Casteo 3

        public static short ConvertirIntAShort(int a)
        {
            return (short)a;
        }


        //13

        //  Ejercicio Switch 

        public static string QueColorEs(Color color)
        {
            switch (color)
            {
                case Color.Blanco:
                    return "Este es Blanco";

                case Color.Azul:
                    return "Este es Azul";

                case Color.Negro:
                    return "Este es Negro";

                default:
                    return "Color no encontrado";
            }
        }


        //14

        //  Ejercicio Sentencia if y else 

        public static string EsMayorA(int a)
        {
            if (a > 10)
            {
                return "Es mayor a 10";
            }
            else
            {
                return "Error";
            }
        }




        //15


        //  Ejercicio prueba de lazo for


        public static string Prueba_Lazo_for(int numero)
        {
            numero = 0;
            
            for(int i = 0; i <= 10; i++)
            {

                numero  = numero + 1;

            }

            return "El valor es: " + numero;
        }







    }
}
