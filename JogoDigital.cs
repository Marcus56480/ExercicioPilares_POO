namespace Exercicios_Csharp
{
    public class JogoDigital : Jogo
    {
        public JogoDigital()
        {
            
        }

        public JogoDigital(string nome, string plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
        }

        public override void Apresentarjogo()
        {
            Console.WriteLine($"Tipo: Jogo Digital - Nome: {Nome} - Platafotma: {Plataforma}");
        }
    }
}