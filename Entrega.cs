namespace Exercicios_Csharp
{
    public abstract class Entrega
    {
        public double Distancia { get; set; }

        public abstract decimal CalcularFrete();
    }
}