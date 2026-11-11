using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtvHerancaPolimorfismo
{
    public class Notificacao
    {
        public string Mensagem { get; set; }
        public virtual void Enviar(string Mensagem)
        {
        }
    }
}