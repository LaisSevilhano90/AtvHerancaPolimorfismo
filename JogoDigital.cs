
namespace AtvHerancaPolimorfismo
{
    public class JogoDigital : Jogo
    {
        public int TamanhoGB { get; set; }
        public string LojaVirtual { get; set; }
       public JogoDigital(string nome, string plataforma, int tamanhoGB, string lojaVirtual ) : base(nome, plataforma)
        {
            TamanhoGB = tamanhoGB;
            LojaVirtual = lojaVirtual;
        }

        public override void ExibirJogo()
        {
            base.ExibirJogo();
            Console.WriteLine($" Tamanho: {TamanhoGB},  Disponivel em: {LojaVirtual}");
        }
    }
}