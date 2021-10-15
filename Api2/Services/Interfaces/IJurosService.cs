namespace Api2.Services
{
   public interface IJurosService
   {
      double CalcularJuros(double valorInicial, int meses, double juros);
   } 
}