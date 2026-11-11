using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtvHerancaPolimorfismo
{
    public class CursoOnline : ProdutoDigital
    {
        public int CargaHoraria { get; set; }

        public CursoOnline(int cargaHoraria, string nome, double preco) : base(nome, preco)
        {
            CargaHoraria = cargaHoraria;
        }

           public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Carga Horaria: {CargaHoraria}");
        }
    }
}