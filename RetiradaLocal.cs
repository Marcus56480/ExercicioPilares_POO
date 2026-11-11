namespace Exercicios_Csharp
{
    public class RetiradaLocal : Entrega
    {
        public override decimal CalcularFrete()
        {
            // Console.WriteLine($"Sem custo de Frete");

            return 0.00m;
        }
    }
}