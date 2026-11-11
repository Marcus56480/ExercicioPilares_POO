namespace Exercicios_Csharp
{
    public class CursoOnline : ProdutoDigital
    {
        public decimal CargaHoraria { get; set; }

        public CursoOnline()
        {
            
        }

        public CursoOnline(string nome, decimal preco, decimal cargaHoraria) : base(nome, preco)
        {
            CargaHoraria = cargaHoraria;
        }
    }
}