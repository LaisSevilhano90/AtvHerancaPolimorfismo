using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtvHerancaPolimorfismo
{
    public class Jogo
    {
        public string Nome { get; set; }

        protected string Plataforma;

        public Jogo(string nome, string plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
        }

        public virtual void ExibirJogo()
        {
            Console.WriteLine($"Nome: {Nome},  Plataforma: {Plataforma}");
        }
    }
}