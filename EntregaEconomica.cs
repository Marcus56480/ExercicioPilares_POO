namespace Exercicios_Csharp
{
    public class EntregaEconomica : Entrega
    {
        public override void CalcularFrete(double distancia)
        {
            Distancia = distancia;
            Console.WriteLine($"Valor do frete: {0.1 * Distancia:C}");
        }
    }
}