using Console_App_TP1;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

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
        public void Enumerar()
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



        //  Test Ejercicio Conversiones 4


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






        // Test Ejercicio Casteo 1

        [TestMethod]
        public void Casteo1()
        {
            // Dado
            var number = 344.4;

            int esperado = 344;

            int resultado = Calcs.ConvertirDoubleAInt(number);

            // comparación

            Assert.AreEqual(esperado, resultado);

        }


        // Test Ejercicio Casteo 2

        [TestMethod]
        public void Casteo2()
        {
            // Dado
            var number = 10;
            decimal esperado = 10;
            // Cuando
            decimal resultado = Calcs.ConvertirIntADecimal(number);

            // comparación            
            Assert.AreEqual(esperado, resultado);
        }



        // Test Ejercicio Casteo 3

        [TestMethod]
        public void Casteo3()
        {
            // Dado
            int number = 443444;

            short esperado = -15308;
            
            short resultado = Calcs.ConvertirIntAShort(number);

            // comparación
            // 
            Assert.AreEqual(esperado, resultado);
        }











    }
}