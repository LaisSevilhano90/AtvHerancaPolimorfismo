using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtvHerancaPolimorfismo
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }

        public Carro(int quantidadePortas, string marca, string modelo) : base(marca, modelo)
        {
            QuantidadePortas = quantidadePortas;
        }

        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"Quantidade de Portas: {QuantidadePortas}");
        }
    }
}