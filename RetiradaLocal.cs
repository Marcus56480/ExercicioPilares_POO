namespace Exercicios_Csharp
{
    public class RetiradaLocal : Entrega
    {
        public override void CalcularFrete(double distancia)
        {
            Console.WriteLine($"Sem custo de Frete");
        }
    }
}