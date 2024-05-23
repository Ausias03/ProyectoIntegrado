namespace GestionisTests
{
    public static class Utilidades
    {
        public static int ProgramarGrafico(double valor1, double valor2)
        {
            double diferencia = Math.Abs(valor1 - valor2);
            double valorMax = Math.Max(valor1, valor2) + (diferencia / 2);
            return (int)Math.Ceiling(valorMax);
        }
    }

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestProgramarGrafico_ComportamientoEsperado()
        {
            // Arrange
            double valor1 = 100;
            double valor2 = 50;
            int expected = 125;

            // Act
            int result = Utilidades.ProgramarGrafico(valor1, valor2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestProgramarGrafico_ValoresIguales()
        {
            // Arrange
            double valor1 = 100;
            double valor2 = 100;
            int expected = 100;

            // Act
            int result = Utilidades.ProgramarGrafico(valor1, valor2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestProgramarGrafico_Valor1MayorQueValor2()
        {
            // Arrange
            double valor1 = 200;
            double valor2 = 150;
            int expected = 225;

            // Act
            int result = Utilidades.ProgramarGrafico(valor1, valor2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestProgramarGrafico_Valor2MayorQueValor1()
        {
            // Arrange
            double valor1 = 150;
            double valor2 = 200;
            int expected = 225;

            // Act
            int result = Utilidades.ProgramarGrafico(valor1, valor2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestProgramarGrafico_ValoresConDecimales()
        {
            // Arrange
            double valor1 = 100.5;
            double valor2 = 50.3;
            int expected = 126;

            // Act
            int result = Utilidades.ProgramarGrafico(valor1, valor2);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
