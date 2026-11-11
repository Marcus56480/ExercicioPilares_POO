namespace Exercicios_Csharp
{
    public class NotificacaoPush : Notificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Mensagem enviada com sucesso via Push");
        }
    }
}