using System;
using Xunit;

namespace tests
{
    public class Api2
    {
        [Theory]
        [InlineData(3248, 2, 3313.28)]
        [InlineData(0, 0, 0)]
        [InlineData(100, 0, 100)]
        [InlineData(100, 2, 102.01)]
        [InlineData(-100, 1, -101.0)]
        [InlineData(100, -1, 99.01)] // Precisaria verificar se é um teste válido ou se eu deveria tratar mês negativo
        public async void CalculoTaxaJuros(double inicial, int tempo, double esperado)
        {
            double atual = double.Epsilon;

            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Environment.GetEnvironmentVariable("Api2Uri"));

                var response = await client.GetAsync($"api/Juros/calcularJuros?valorInicial={inicial}&meses={tempo}");
                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();

                    atual = Convert.ToDouble(responseString);
                }
                else{
                    throw new Exception($"{response.Content.ReadAsStringAsync().Result}");
                }
            }

            Assert.Equal(esperado, atual);
        }
    }
}
