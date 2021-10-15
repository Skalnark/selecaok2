using System;
using Api1.Services;
using Xunit;

namespace tests
{
    public class Api1
    {
        [Fact]
        public void ValorCorretoTaxaJuros()
        {
            var taxa = new TaxaService().GetTaxaJuros();
            double expected = 0.01;

            Assert.Equal(expected, taxa);
        }
    }
}
