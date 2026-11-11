using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtvHerancaPolimorfismo
{

    public class NotificacaoEmail : Notificacao
    {
        public override void Enviar()
        {
            base.Enviar();
            Console.WriteLine("Mensagem por Email: Você recebeu uma msgm por email");
        }
    }
}