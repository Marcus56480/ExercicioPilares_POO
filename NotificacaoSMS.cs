namespace Exercicios_Csharp
{
    public class NotificacaoSMS : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Mensagem enviada com sucesso via SMS");
        }
    }
}