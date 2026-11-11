using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace AtvHerancaPolimorfismo
{
    public class Motocicleta : Veiculo
    {
        public int cilindradas { get; set; }

        public Motocicleta(int Cilindradas, string marca, string modelo) : base(marca, modelo)
        {
            cilindradas = Cilindradas;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Quantidade de Portas: {cilindradas}");
        }

    }
}