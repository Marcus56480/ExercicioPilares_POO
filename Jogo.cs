namespace Exercicios_Csharp
{
    public abstract class Jogo
    {
        public string? Nome { get; set;}
        protected string? Plataforma { get; set;}

        public abstract void Apresentarjogo();

    }
}