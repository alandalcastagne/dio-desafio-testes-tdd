using System;
using Xunit;
using NewTalents;


namespace TestNewTalents
{
    public class UnitTest1
    {

        public Calculadora ConstruirClasse()
        {
            string data = "02/02/2020";
            Calculadora calc = new Calculadora("02/02/2020");
            return calc;
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
        Calculadora calc = ConstruirClasse()

        int resultadoCalculadora = calc.Somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
        }


        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = ConstruirClasse()

            int resultadoCalculadora = calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }


        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = ConstruirClasse()

            int resultadoCalculadora = calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }


        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = ConstruirClasse()

            int resultadoCalculadora = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = ConstruirClasse()

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3,0)
                );
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.Somar(1, 2);
            calc.Somar(5, 4);
            calc.Somar(8, 7);
            calc.Somar(9, 3);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }


}