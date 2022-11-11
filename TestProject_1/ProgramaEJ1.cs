using Console_App_TP1;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Security.Cryptography;

namespace TestProject_1
{
    [TestClass]
    public class ProgramaEJ1
    {


        //  Test Ejercicio 1

        [TestMethod]
        public void Testsumar()
        {

            // Dados estos valores:
            int a = 1;
            int b = 2;

            int esperado = 3;

            int calculado  = Calcs.Sumar(a, b);


            // comparación

            Assert.AreEqual(esperado, calculado);



        }


        //  Test Ejercicio 2

        [TestMethod]
        public void Testcadena()
        {
            // Dado            
            string a = "diversos";
            string esperado = "dive";            
            
            string resultado = Calcs.cadenacortada(a);
            
            // comparación
                        
            Assert.AreEqual(esperado, resultado);

        }


        //  Test Ejercicio 3

        [TestMethod]
        public void saberhora()
        {
            // Dado            
            
            string esperado = DateTime.Now.ToString("dd-MM-yy hh:mm");
                        
            string resultado = Calcs.quehoraes();

            // comparación

            Assert.AreEqual(esperado, resultado);
        }


        //  Test Ejercicio 4 y 5  (no son necesarios)





        //  Test Ejercicio Enumeración 1 y 2


        [TestMethod]
        public void Enumera1()
        {
            // Dado            
            string esperado = "Hoy es día Lunes";
                        
            string resultado = Calcs.DiasSemana(2);

            // comparación            
            Assert.AreEqual(esperado, resultado);
        }



        //  Test Ejercicio Conversiones 1 parte A

        [TestMethod]
        public void Conver1()
        {
            // Dado

            int verdadero = 1;

            bool esperado = true;
            
            bool resultado = Calcs.Conver_V_F(verdadero);

            // comparación
             
            Assert.AreEqual(esperado, resultado);
        }



        //  Test Ejercicio Conversiones 1  parte B

        [TestMethod]
        public void Conver2()
        {
            // Dado
            int falso = 0;

            bool esperado = false;
            
            bool resultado = Calcs.Conver_V_F(falso);

            // comparación

            Assert.AreEqual(esperado, resultado);
        }



        //  Test Ejercicio Conversiones 2

        [TestMethod]
        public void Conver3()
        {
            // Dado
            string falso = "false";
            bool esperado = false;
           

            bool resultado = Calcs.BoolParseado(falso);

            // comparación
            
            Assert.AreEqual(esperado, resultado);

        }




        [TestMethod]
        public void Conver4()
        {
            // Dado
            string verdadero = "true";

            bool esperado = true;

            
            bool resultado = Calcs.BoolParseado(verdadero);

            // comparación

            Assert.AreEqual(esperado, resultado);
        }






    }
}