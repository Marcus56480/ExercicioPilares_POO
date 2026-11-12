namespace Exercicios_Csharp
{
    public class EntregaEconomica : Entrega
    {
        public override decimal CalcularFrete()
        {
            // Console.WriteLine($"Valor do frete: {0.1 * Distancia:C}");

            return (decimal)Distancia * 0.10m;
        }
    }
}