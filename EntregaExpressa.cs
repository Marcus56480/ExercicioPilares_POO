namespace Exercicios_Csharp
{
    public class EntregaExpressa : Entrega
    {
        public override void CalcularFrete(double distancia)
        {
            Distancia = distancia;
            Console.WriteLine($"Valor do frete: {0.2 * Distancia:C}");
        }
    }
}