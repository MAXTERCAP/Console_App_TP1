using Console_App_TP1;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestProject_1
{
    [TestClass]
    public class ProgramaEJ1
    {
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
    }
}