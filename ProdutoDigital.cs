
namespace AtvHerancaPolimorfismo
{
    public abstract class ProdutoDigital
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public ProdutoDigital(String nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

         public virtual void  ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}, Preço: {Preco}");
        }
    }
}