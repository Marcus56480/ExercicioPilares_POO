namespace Exercicios_Csharp
{
    public class JogoFisico : Jogo
    {
        public JogoFisico ()
        {
            
        }        

        public JogoFisico (string nome, string plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
        }

        public override void Apresentarjogo()
        {
            Console.WriteLine($"Tipo: Jogo Fisico - Nome: {Nome} - Platafotma: {Plataforma}");
        }
    }
}