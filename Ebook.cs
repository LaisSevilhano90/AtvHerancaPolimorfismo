
namespace AtvHerancaPolimorfismo
{
    public class Ebook : ProdutoDigital
    {
        public int QuantidadePaginas { get; set; }

        public Ebook(int QuantidadePaginas, string nome, Double preco) : base(nome, preco)
        { 
        }

         public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Quantidade de Paginas: {QuantidadePaginas}");
        }
    }
}