using System;
using Xunit;

namespace tests
{
    public class Api1
    {
        [Fact]
        public async void ValorCorretoTaxaJuros()
        {
            double esperado = 0.01;
            double atual = double.Epsilon;
            
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(Environment.GetEnvironmentVariable("Api1Uri"));

                var response = await client.GetAsync($"api/Taxa/taxaJuros");
                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();

                    atual = Convert.ToDouble(responseString);
                }
            }

            Assert.Equal(esperado, atual);
        }
    }
}
