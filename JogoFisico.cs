namespace AtvHerancaPolimorfismo
{
    public class JogoFisico : Jogo
    {
        public string TipoMidia { get; set; }
        public bool IncluiManual { get; set; }

        public JogoFisico(string nome, string plataforma, string tipoMidia, bool incluiManual ) : base(nome, plataforma)
        {
            TipoMidia = tipoMidia;
            IncluiManual = incluiManual;
        }

        public override void ExibirJogo()
        {
            base.ExibirJogo();
            Console.WriteLine($" Tipo de midia: {TipoMidia}, Inclui manuel: {IncluiManual}");
        }
    }
}