namespace Exercicios_Csharp
{
    public class EntregaExpressa : Entrega
    {
        public override decimal CalcularFrete()
        {
            // Console.WriteLine($"Valor do frete: {0.2 * Distancia:C}");

            return (decimal)Distancia * 0.2m;
        }
    }
}