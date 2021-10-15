using System;
using Api1.Services;
using Api2.Services;
using Xunit;

namespace tests
{
    public class Api2
    {
        [Theory]
        [InlineData(3248, 2, 3313.28)]
        [InlineData(0, 0, 0)]
        [InlineData(100, 0, 100)]
        [InlineData(-100, 1, -101.0)]
        [InlineData(100, -1, 99.01)] // Precisaria verificar se é um teste válido ou se eu deveria tratar mês negativo
        public void CalculoTaxaJuros(double inicial, int tempo, double esperado)
        {
            var juros = new TaxaService().GetTaxaJuros();
            var atual = new JurosService().CalcularJuros(inicial, tempo, juros);

            Assert.Equal(esperado, atual);
        }
    }
}
