using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Api2.Services
{
    public class JurosService : IJurosService
    {
        private Uri _api1Uri;

        public JurosService(IConfiguration config)
        {
           _api1Uri = new Uri(config.GetValue<string>("Api1Uri"));
        }

        public double CalcularJuros(double valorInicial, int meses)
        {
            double juros;
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = _api1Uri;
                var response = client.GetAsync($"api/taxa/taxaJuros").Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseString = response.Content.ReadAsStringAsync().Result;

                    juros = Convert.ToDouble(responseString);
                }
                else
                {
                    throw new Exception(response.Content.ReadAsStringAsync().Result);
                }
            }

            return Math.Round(valorInicial * Math.Pow((1 + juros), meses), 2);
        }
    }
}