namespace Exercicios_Csharp
{
    public class Relatorio : IImprimivel, IExportavel
    {
        public void Exportar()
        {
            Console.WriteLine("Relatario Exportado com Sucesso");
        }

        public void Imprimir()
        {
            Console.WriteLine("Relatario Imprimido com Sucesso");
        }

  
    }
}