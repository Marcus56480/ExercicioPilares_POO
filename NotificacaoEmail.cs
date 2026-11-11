namespace Exercicios_Csharp
{
    public class NotificacaoEmail : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Mensagem enviada com sucesso via Email");
        }
    }
}