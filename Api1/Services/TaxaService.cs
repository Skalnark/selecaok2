using System;

namespace Api1.Services
{ 
    // Optei por não tornar a classe abstrata para garantir o 
    // IOC e facilitar mudança futura.
    public class TaxaService : ITaxaService
    {
        public double GetTaxaJuros()
        {
            return 0.01;
        }
    }
}