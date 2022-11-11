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





        //  Test Ejercicio Enumeración 1


        [TestMethod]
        public void Enumera1()
        {
            // Dado            
            string esperado = "Hoy es día Domingo";
                        
            string resultado = Calcs.DiasSemana(1);

            // comparación            
            Assert.AreEqual(esperado, resultado);
        }




    }
}